using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.Serv.Models;
using Demo.Serv.Repository;

namespace Demo.Serv.Infrastructures
{
    public abstract class ExecutorFactoryBase
    {
        public virtual IRepository Repository { get; }
        public abstract IExecutor GetExecutor(Tasks task);
    }
}
