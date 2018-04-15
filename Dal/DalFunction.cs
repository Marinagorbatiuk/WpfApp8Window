using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dal
{
    public class DalFunction
    {
        public Staff GetUser(string login, string passWord)
        {
            Staff staff = null;
           
            using (ModelBeauty model = new ModelBeauty())
            {
                staff = model.Staffs.Where(x => x.Login == login && x.Password == passWord).FirstOrDefault();
            }
      
            return staff;
        }

        public ICollection<WorkPosition> GetWorkPosition ()
        {
            ICollection<WorkPosition> works = null;
            using (ModelBeauty model = new ModelBeauty())
            {
                works = model.WorkPositions.ToList();
            }
                return works;

        }

        public WorkPosition GetOneWorkPosition(int Id)
        {
            WorkPosition workPosition = null;

            using (ModelBeauty model = new ModelBeauty())
            {
                Staff staff = model.Staffs.Where(x => x.Id == Id).First();
              
                workPosition = staff.WorkPosition;
            }
                return workPosition;
        }

        public List<Shampoo> GetShampoo()
        {
            List<Shampoo> shampoo = new List<Shampoo>();
            using (ModelBeauty model = new ModelBeauty())
            {
                shampoo = model.Materials.Where(x => (x is Shampoo)).Select(y=>(y as Shampoo)).ToList();
            }

                return shampoo;
        }

        public void Delete(int id)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Remove(model.Materials.Where(x => x.Id == id).First());
                model.SaveChanges();
            }
        }
    }
}
