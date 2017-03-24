using System.IO;
using System.Management;
using System.Threading.Tasks;

namespace Demo.Serv.Helpers
{
    public static class Win32Helper
    {
        public static string GetSerialNumber()
        {
            var cpuInfo = string.Empty;
            var mc = new ManagementClass("win32_processor");
            var moc = mc.GetInstances();

            foreach (var mo in moc)
            {
                cpuInfo = mo.Properties["processorID"].Value.ToString();
                break;
            }

            return cpuInfo;
        }
         
    }
}