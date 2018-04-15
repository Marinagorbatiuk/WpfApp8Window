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
        public List<Balsam> GetBalsam()
        {
            List<Balsam> balsam = new List<Balsam>();
            using (ModelBeauty model = new ModelBeauty())
            {
                balsam = model.Materials.Where(x => (x is Balsam)).Select(y => (y as Balsam)).ToList();
            }

            return balsam;
        }
        public List<HairColor> GetColor()
        {
            List<HairColor> color = new List<HairColor>();
            using (ModelBeauty model = new ModelBeauty())
            {
                color = model.Materials.Where(x => (x is HairColor)).Select(y => (y as HairColor)).ToList();
            }

            return color;
        }
        public List<Foundation> GetFoundation()
        {
            List<Foundation> foundation = new List<Foundation>();
            using (ModelBeauty model = new ModelBeauty())
            {
                foundation = model.Materials.Where(x => (x is Foundation)).Select(y => (y as Foundation)).ToList();
            }

            return foundation;
        }
        public List<Laque> GetLaque()
        {
            List<Laque> laque = new List<Laque>();
            using (ModelBeauty model = new ModelBeauty())
            {
                laque = model.Materials.Where(x => (x is Laque)).Select(y => (y as Laque)).ToList();
            }

            return laque;
        }
        public List<Lipstick> GetLipstick()
        {
            List<Lipstick> lipstick = new List<Lipstick>();
            using (ModelBeauty model = new ModelBeauty())
            {
                lipstick = model.Materials.Where(x => (x is Lipstick)).Select(y => (y as Lipstick)).ToList();
            }

            return lipstick;
        }
        public List<Mascara> GetMascara()
        {
            List<Mascara> mascara = new List<Mascara>();
            using (ModelBeauty model = new ModelBeauty())
            {
                mascara = model.Materials.Where(x => (x is Mascara)).Select(y => (y as Mascara)).ToList();
            }

            return mascara;
        }
        public List<NailBase> GetNailBase()
        {
            List<NailBase> nailBases = new List<NailBase>();
            using (ModelBeauty model = new ModelBeauty())
            {
                nailBases = model.Materials.Where(x => (x is NailBase)).Select(y => (y as NailBase)).ToList();
            }

            return nailBases;
        }
        public List<NailPolish> GetNailPolish()
        {
            List<NailPolish> nailPolish = new List<NailPolish>();
            using (ModelBeauty model = new ModelBeauty())
            {
                nailPolish = model.Materials.Where(x => (x is NailPolish)).Select(y => (y as NailPolish)).ToList();
            }

            return nailPolish;
        }
        public List<NailTop> GetNailTop()
        {
            List<NailTop> nailTop = new List<NailTop>();
            using (ModelBeauty model = new ModelBeauty())
            {
                nailTop = model.Materials.Where(x => (x is NailTop)).Select(y => (y as NailTop)).ToList();
            }

            return nailTop;
        }
        public List<Powder> GetPowder()
        {
            List<Powder> powder = new List<Powder>();
            using (ModelBeauty model = new ModelBeauty())
            {
                powder = model.Materials.Where(x => (x is Powder)).Select(y => (y as Powder)).ToList();
            }

            return powder;
        }
        public List<Shadows> GetShadow()
        {
            List<Shadows> shadows = new List<Shadows>();
            using (ModelBeauty model = new ModelBeauty())
            {
                shadows = model.Materials.Where(x => (x is Shadows)).Select(y => (y as Shadows)).ToList();
            }

            return shadows;
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
