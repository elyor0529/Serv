using Demo.Serv.Models;
using Demo.Serv.Properties;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Serv
{
    public class TaskDbContext : DbContext  
    {

        public TaskDbContext():base(Settings.Default.SqlConnection)
        {
            
        }

        public virtual DbSet<Tasks> Tasks { get; set; }

    }
}
