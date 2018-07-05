using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.ServiceReference1;
namespace Dal
{
 public   class AddFunction
    {
        
        private Service1Client client = new Service1Client();
        public List<string> WritingOff(List<WriteOffMaterials> writeOffMaterials)
        {
            return client.WritingOff(writeOffMaterials.Select(x => Convertation.ConvertWriteOffToBD(x)).ToArray()).ToList();
        }
        public void AddEmployee(Staff staff)
        {
            client.AddEmployee(Convertation.ConvertStaffToWCF(staff));
        }
        public void AddMaterialsToDB( Material materials)
        {
            client.AddMaterials(Convertation.ConvertMaterialsToDB(materials));
        }
       

    }
}
