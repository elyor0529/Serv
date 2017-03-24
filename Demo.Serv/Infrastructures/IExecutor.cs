using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Serv.Repository;

namespace Demo.Serv.Infrastructures
{
    public interface IExecutor : IDisposable
    {
        IRepository Repository { get; set; }
        Task<object> Run();
    }
}
