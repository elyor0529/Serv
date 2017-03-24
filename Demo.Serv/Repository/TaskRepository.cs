using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Serv.Helpers;
using Demo.Serv.Models;

namespace Demo.Serv.Repository
{
    public class TaskRepository : IRepository
    {
        private readonly TaskDbContext _context;

        public TaskRepository(TaskDbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            _context = context;
        }

        public TaskRepository() : this(new TaskDbContext())
        {
        }

        public void Dispose()
        {
            _context.Dispose();

            GC.SuppressFinalize(this);
        }

        public async Task<Tasks> FindById(long id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task<Tasks> FetchForExecution()
        {
            var selectSql = String.Format(@"SELECT TOP 1 * FROM [Tasks] WHERE [SchedulerTime]> GETDATE() AND Status={0}",
                (int)OperationStatus.NotStarted);
            var ent = await _context.Database.SqlQuery<Tasks>(selectSql).FirstOrDefaultAsync();

            if (ent == null)
                return null;

            var updateSql = String.Format("UPDATE [Tasks] SET MachineId='{0}' , Status={1} WHERE Id={2}",
                Win32Helper.GetSerialNumber(), (int)OperationStatus.InProcess, ent.Id);

            await _context.Database.ExecuteSqlCommandAsync(TransactionalBehavior.EnsureTransaction, updateSql);

            return await _context.Tasks.FindAsync(ent.Id);
        }

        public async Task Save(Tasks tasks)
        {
            _context.Tasks.Attach(tasks);
            _context.Entry(tasks).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

    }
}
