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
        
        //public void UpdateShampoo(Shampoo Shampoo)
        //{
        //    client.UpdateShampoo(Convertation.ConvertShampoToWcf(Shampoo));
        //}
        //public void UpdateBalsam(Balsam Balsam)
        //{
        //    client.UpdateBalsam(Convertation.ConvertBalsamToWCF(Balsam));
        //}
        //public void UpdateLaque(Laque Laque)
        //{
        //    client.UpdateLaque(Convertation.ConvertLaqueToWCF(Laque));
        //}
        //public void UpdateColor(HairColor Color)
        //{
        //    client.UpdateColor(Convertation.ConvertColorToWCF(Color));
        //}
        //public void UpdateFoundation(Foundation Foundation)
        //{
        //    client.UpdateFoundation(Convertation.ConvertFoundationToWCF(Foundation));
        //}
        //public void UpdatePowder(Powder Powder)
        //{
        //    client.UpdatePowder(Convertation.ConvertPowderToWCf(Powder));
        //}
        //public void UpdateShadow(Shadows Shadows)
        //{
        //    client.UpdateShadow(Convertation.ConvertShadowToWCF(Shadows));
        //}
        //public void UpdateMascara(Mascara Mascara)
        //{
        //    client.UpdateMascara(Convertation.ConvertMascaraToWCF(Mascara));
        //}
        //public void UpdateLipstick(Lipstick Lipstick)
        //{
        //    client.UpdateLipstick(Convertation.ConvertLipstickToWCF(Lipstick));
        //}
        //public void UpdateNailBase(NailBase NailBase)
        //{
        //    client.UpdateBase(Convertation.ConvertBaseToWCf(NailBase));
        //}
        //public void UpdatePolish(NailPolish NailPolish)
        //{
        //    client.UpdatePolish(Convertation.ConvertPolishToWCF(NailPolish));
        //}
        //public void UpdateTop(NailTop NailTop)
        //{
        //    client.UpdateTop(Convertation.ConvertTopTOWcf(NailTop));
        //}
    }
}
