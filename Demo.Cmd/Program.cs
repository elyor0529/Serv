using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using Topshelf;
using Demo.Serv.Logs;

namespace Demo.Cmd
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<TownCrier>(s =>
                {
                    s.ConstructUsing(name => new TownCrier());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();
                x.UseLog4Net(Path.Combine(Environment.CurrentDirectory, "log4net.config"));
                x.OnException(a =>
                {
                    Log4NetManager.Error(a.ToString());
                });
                x.SetDescription("Demo Service");
                x.SetDisplayName("Demo ");
                x.SetServiceName("Demo");
            });
        }

    }
}
