using Demo.Serv.Helpers;
using Demo.Serv.Models;

namespace Demo.Serv.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(TaskDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Tasks.AddOrUpdate(p => p.Id, new Tasks[]
            {
                new Tasks
                {
                    Id = 1,
                    Name = "Email sender",
                    SchedulerTime = DateTime.Now.AddMinutes(5),
                    MachineId = Win32Helper.GetSerialNumber(),
                    Type = TaskType.Email,
                    JSONParams ="{ \"Recipiend\":\"elyor@outlook.com\", \"Subject\":\"test\",\"Body\":\"test email\"}"
                },
                new Tasks
                {
                    Id = 2,
                    Name = "File creater",
                    SchedulerTime = DateTime.Now.AddMinutes(5),
                    MachineId = Win32Helper.GetSerialNumber(),
                    Type = TaskType.File,
                    JSONParams = "{ \"Root\":\"C:\\tmp\\\",\"File\":\"foo.txt\"}"
                }
            });
        }
    }
}
