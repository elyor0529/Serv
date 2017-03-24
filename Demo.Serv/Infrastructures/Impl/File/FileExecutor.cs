using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Demo.Serv.Helpers;
using Demo.Serv.Logs;
using Demo.Serv.Models;
using Demo.Serv.Repository;
using Newtonsoft.Json;

namespace Demo.Serv.Infrastructures.Impl.File
{
    public class FileExecutor : IExecutor
    {
        private readonly Tasks _tasks;

        public FileExecutor(Tasks tasks)
        {
            if (tasks == null)
                throw new ArgumentNullException("tasks");

            _tasks = tasks;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IRepository Repository { get; set; }

        public async Task<object> Run()
        {
            try
            {
                var args = JsonConvert.DeserializeObject<FileArg>(_tasks.JSONParams);
                var path = Path.Combine(args.Root, DateTime.Now.Ticks + "_" + args.File);

                Thread.Sleep(10 * 1000);
                System.IO.File.Create(path, 1024, FileOptions.Asynchronous);

                _tasks.Status = OperationStatus.Done;
            }
            catch (Exception exception)
            {
                Log4NetManager.Error(exception.ToString());

                _tasks.Status = OperationStatus.Fealed;
            }

            await Repository.Save(_tasks);

            return Task.FromResult(_tasks);
        }

    }
}
