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
        //public void AddShampooToDB(Shampoo shampoo)
        //{
        //    client.AddShampoo(Convertation.ConvertShampoToWcf(shampoo));
        //}
        //public void AddBalsamToDB(Balsam balsam)
        //{
        //    client.AddBalsam(Convertation.ConvertBalsamToWCF(balsam));
        //}
        //public void AddColorToDB(HairColor color)
        //{
        //    client.AddColor(Convertation.ConvertColorToWCF(color));
        //}
        //public void AddLaqueToDB(Laque laque)
        //{
        //    client.AddLaque(Convertation.ConvertLaqueToWCF(laque));
        //}
        //public void AddFoundationToDB(Foundation foundation)
        //{
        //    client.AddFoundation(Convertation.ConvertFoundationToWCF(foundation));
        //}
        //public void AddLipstickToDB(Lipstick lipstick)
        //{
        //    client.AddLipstick(Convertation.ConvertLipstickToWCF(lipstick));
        //}
        //public void AddMascaraToDB(Mascara Mascara)
        //{
        //    client.AddMascara(Convertation.ConvertMascaraToWCF(Mascara));
        //}
        //public void AddPowderToDB(Powder powder)
        //{
        //    client.AddPowder(Convertation.ConvertPowderToWCf(powder));
        //}
        //public void AddShadowToDB(Shadows Shadows)
        //{
        //    client.AddShadow(Convertation.ConvertShadowToWCF(Shadows));
        //}
        //public void AddPolishToDB(NailPolish NailPolish)
        //{
        //    client.AddPolish(Convertation.ConvertPolishToWCF(NailPolish));
        //}
        //public void AddTopToDB(NailTop NailTop)
        //{
        //    client.AddTop(Convertation.ConvertTopTOWcf(NailTop));
        //}
        //public void AddBaseToDB(NailBase NailBase)
        //{
        //    client.AddBase(Convertation.ConvertBaseToWCf(NailBase));
        //}

    }
}
