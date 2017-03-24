using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Demo.Serv.Models;

namespace Demo.Serv.Repository
{
    public interface IRepository : IDisposable
    {

        Task<Tasks> FindById(long id);

        Task<Tasks> FetchForExecution();

        Task Save(Tasks tasks);

    }
}
