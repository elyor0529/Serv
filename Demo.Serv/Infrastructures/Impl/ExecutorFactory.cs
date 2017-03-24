using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Serv.Infrastructures.Impl.Email;
using Demo.Serv.Infrastructures.Impl.File;
using Demo.Serv.Models;
using Demo.Serv.Repository;

namespace Demo.Serv.Infrastructures.Impl
{
    public class ExecutorFactory : ExecutorFactoryBase
    {

        public ExecutorFactory(IRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }

            Repository = repository;
        }

        public override IRepository Repository { get; }

        public override IExecutor GetExecutor(Tasks task)
        {
            if (task.Type == null)
                throw new ArgumentNullException("task");

            IExecutor executor = null;

            switch (task.Type)
            {
                case TaskType.File:
                    executor = new FileExecutor(task);
                    break;
                case TaskType.Email:
                    executor = new EmailExecutor(task);
                    break;
            }

            if (executor != null)
            {
                executor.Repository = Repository;
            }

            return executor;
        }
    }
}
