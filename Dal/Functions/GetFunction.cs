using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.ServiceReference1;
namespace Dal
{
    class GetFunction
    {
        private Service1Client client = new Service1Client();
        public Staff GetUserAutorization(string login, string password)
        {
            Staff staff = null;
            StaffWCF staffwcf = client.GetUserAutorization(login, password);
            if (staff != null)
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
        public List<Shadows> GetListShadow()
        {
            List<Shadows> ShadowList = new List<Shadows>();
            ShadowList = client.GetListShadow().Select(x => Convertation.ConvertShadowToDAl(x)).ToList();
            return ShadowList;
        }
        public List<Shampoo> GetListShampoo()
        {
            List<Shampoo> ShampoosList = new List<Shampoo>();
            ShampoosList = client.GetListShampoo().Select(x => Convertation.ConvertShampooToDal(x)).ToList();
            return ShampoosList;
        }
        public List<Balsam> GetListBalsam()
        {

            List<Balsam> BalsamList = new List<Balsam>();
            BalsamList = client.GetListBalsam().Select(x => Convertation.ConvertBalsamToDAL(x)).ToList();
            return BalsamList;
        }
        public List<HairColor> GetListColor()
        {
            List<HairColor> ColorList = new List<HairColor>();
            ColorList = client.GetListColor().Select(x => Convertation.ConvertColorToDal(x)).ToList();
            return ColorList;
        }
        public List<Foundation> GetListFoundation()
        {
            List<Foundation> FoundationList = new List<Foundation>();
            FoundationList = client.GetListFoundation().Select(x => Convertation.ConvertFoundationToDal(x)).ToList();
            return FoundationList;
        }

        public List<Laque> GetListLaque()
        {
            List<Laque> LaqueList = new List<Laque>();
            LaqueList = client.GetListLaque().Select(x => Convertation.ConvertLaqueToDal(x)).ToList();
            return LaqueList;
        }
        public List<Lipstick> GetListLipstick()
        {
            List<Lipstick> LipstickList = new List<Lipstick>();
            LipstickList = client.GetListLipstick().Select(x => Convertation.ConvertLipstickToDal(x)).ToList();
            return LipstickList;
        }
        public List<Mascara> GetListMascara()
        {
            List<Mascara> MascaraList = new List<Mascara>();
            MascaraList = client.GetListMascara().Select(x => Convertation.ConvertMascaraToDal(x)).ToList();
            return MascaraList;
        }
        public List<NailBase> GetListNailBase()
        {
            List<NailBase> BaseList = new List<NailBase>();
            BaseList = client.GetListBase().Select(x => Convertation.ConvertBaseToDAL(x)).ToList();
            return BaseList;
        }

        public List<NailPolish> GetListNailPolish()
        {
            List<NailPolish> PolishList = new List<NailPolish>();
            PolishList = client.GetListPolish().Select(x => Convertation.ConvertPolishToDal(x)).ToList();
            return PolishList;
        }
        public List<NailTop> GetListNailTop()
        {
            List<NailTop> TopList = new List<NailTop>();
            TopList = client.GetListTop().Select(x => Convertation.ConvertTopToDal(x)).ToList();
            return TopList;
        }
        public List<Powder> GetListPowder()
        {
            List<Powder> PowderList = new List<Powder>();
            PowderList = client.GetListPowder().Select(x => Convertation.ConvertPowderToDAL(x)).ToList();
            return PowderList;
        }
        //public List<Services> GetListServices()
        //{
        //    List<Services> getlistServices = new List<Services>();
        //    List<ServicesWCF> tmplistServices = client.get;
        //    getlistServices.AddRange(tmplistServices.Select(x => new ServicesWCF
        //    {
        //        Name = x.Name,
        //        Price = x.Price,
        //        WCFMaterials = new List<MaterialsWCF>(x.BllMaterials.Select(y => ConvertationsWCF.ConvertWcfMaterials(y)).ToList())
        //    }).ToList());
        //    return getlistServices;
        //}
    }
}
