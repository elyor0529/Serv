using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using log4net.Core;

namespace Demo.Serv.Logs
{
    public class Log4NetManager
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Log4NetManager));

        static Log4NetManager()
        {
            XmlConfigurator.Configure(new FileInfo("./log4net.config"));
        }

        public static void Error(string msg)
        {
            Log.Error(msg);
        }
         
    }
}
