using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.ServiceReference1;
namespace Dal
{
    class DeleteFunction
    {
        private Service1Client client = new Service1Client();
        public void DeleteEmployee(int id)
        {
            client.DeleteEmployee(id);
        }
        public void DeleteProduct(int id)
        {
            client.DeleteProduct(id);
        }
    }
}
