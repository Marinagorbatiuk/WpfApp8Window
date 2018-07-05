using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.ServiceReference1;

namespace Dal
{
 public   class UpdateFunction
    {
        private Service1Client client = new Service1Client();
        public void UpdateMaterials(Material materials)
        {
            client.UpdateMaterials(Convertation.ConvertMaterialsToDB(materials));
        }
        
       
    }
}
