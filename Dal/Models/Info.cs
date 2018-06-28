using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
  public   class Info
    {
        public  int id { get; set; }
        public string Login { get; set; }
        public string Action { get; set; }
        public DateTime ActionTime { get; set; }
        public string InputParameters { get; set; }
        public string OutputParameters { get; set; }
 
    }
}
