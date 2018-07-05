using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.ServiceReference1;
namespace Dal
{
   public class GetFunction
    {
        private Service1Client client = new Service1Client();

        public ICollection<Info> GetLoggs()
        {

            return client.GetLoggs().Select(x => Convertation.ConvertToBllInfo(x)).ToList();
        }

        public Staff GetUserAutorization(string login, string password)
        {
            Staff staff = null;
            StaffWCF staffwcf = client.GetUserAutorization(login, password);
            if (staffwcf != null)
            {
                staff = new Staff
                {
                    Login = staffwcf.Login,
                    Password = staffwcf.Password,
                    WorkPosition = new WorkPosition
                    {
                        Name = staffwcf.WorkPosition.Name,
                    }
                };
            }
            return staff;
        }
        public void GetChangedQuantity(int QuantityBottles, double QuantityGeneralVolume, int id)
        {
            client.GetChangedQuantity(QuantityBottles, QuantityGeneralVolume, id);
        }
        public List<WorkPosition> GetListPositions()
        {
            List<WorkPosition> positions = new List<WorkPosition>();
            foreach (var item in client.GetListPositions())
            {
                positions.Add(Convertation.ConvertPositionToDal(item));
            }
            
            return positions;
        }
        public List<Staff> GetEmployees()
        {
            List<Staff> Staffs = new List<Staff>();
            Staffs = client.GetEmployees().Select(x => Convertation.ConvertStaffToDal(x)).ToList();

            return Staffs;
        }
        public List<Material> GetMaterials()
        {
            return client.GetListMaterials().Select(x => Convertation.ConvertWcfMaterials(x)).ToList();
        }
       
  
    }
}
