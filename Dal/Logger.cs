using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.ServiceReference1;
namespace Dal
{
    public class Logger
    {
        public static void WriteLog(Info stringToLog)
        {
              Service1Client client = new Service1Client();
        }
    }
}

