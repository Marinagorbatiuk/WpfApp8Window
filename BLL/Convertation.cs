using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Dal;

namespace BLL
{
    class Convertation
    {

        public static BllStaff ConvertStaffToBllStaff(Staff staff)
        {
           //MessageBox.Show("Test");
            BllStaff bllStaff = new BllStaff()
            {
                Id = staff.Id,
                Login = staff.Login,
                Password = staff.Password,
                //WorkPosition = ConvertPositionToBllPosition(staff.WorkPosition)
            };
          //  MessageBox.Show("Test");
            return bllStaff;
        }

        public static BllWorkPosition ConvertPositionToBllPosition(WorkPosition position)
        {
          //  MessageBox.Show("Test");
            BllWorkPosition workPosition = new BllWorkPosition()
            {
                Id = position.Id,
                Name = position.Name,
               // listId = position.Staff.Select(x => x.Id).ToList()
            };
          //  MessageBox.Show("Test");
            return workPosition;
        }

        public static BllShampoo ConvertShampooToBllShampoo(Shampoo shampoo)
        {
            BllShampoo bllShampoo = new BllShampoo()
            {
                Id = shampoo.Id,
                Name = shampoo.Name,
                Brand = shampoo.Brand,
                Description = shampoo.Description,
                Price=shampoo.Price,
                Volume=shampoo.Volume,
                QuantityGeneralVolume=shampoo.QuantityGeneralVolume,
                QuantityBottles=shampoo.QuantityBottles
            };
            return bllShampoo;
        }

        public static BllBalsam ConvertBalsamToBllBalsam(Balsam balsam)
        {
            BllBalsam bllBalsam = new BllBalsam()
            {
                Id = balsam.Id,
                Name = balsam.Name,
                Brand = balsam.Brand,
                Price = balsam.Price,
                Volume = balsam.Volume,
                QuantityGeneralVolume = balsam.QuantityGeneralVolume,
                QuantityBottles = balsam.QuantityBottles
            };
            return bllBalsam;
        }

        public static BllColor ConvertColorToBllColor(HairColor color)
        {
            BllColor bllColor = new BllColor()
            {
                Id = color.Id,
                Name = color.Name,
                Brand = color.Brand,
                Price = color.Price,
                Volume = color.Volume,
                QuantityGeneralVolume = color.QuantityGeneralVolume,
                QuantityBottles = color.QuantityBottles,
                Description= color.Description,
                Color= color.Color
            };
            return bllColor;
        }
        public static BllFoundation ConvertFoundationToBllFoundation(Foundation foundation)
        {
            BllFoundation bllFoundation = new BllFoundation()
            {
                Id = foundation.Id,
                Name = foundation.Name,
                Brand = foundation.Brand,
                Price = foundation.Price,
                Volume = foundation.Volume,
                QuantityGeneralVolume = foundation.QuantityGeneralVolume,
                QuantityBottles = foundation.QuantityBottles,
                Color= foundation.Color,
                Description= foundation.Description
            };
            return bllFoundation;
        }

        public static BllLaque ConvertLaqueToBllLaque(Laque laque)
        {
            BllLaque bllLaque = new BllLaque()
            {
                Id = laque.Id,
                Name = laque.Name,
                Brand = laque.Brand,
                Price = laque.Price,
                Volume = laque.Volume,
                QuantityGeneralVolume = laque.QuantityGeneralVolume,
                QuantityBottles = laque.QuantityBottles,
              
            };
            return bllLaque;
        }
        public static BllLipstick ConvertLipstickToBllLipstick(Lipstick lipstick)
        {
            BllLipstick bllLipstick = new BllLipstick()
            {
                Id = lipstick.Id,
                Name = lipstick.Name,
                Brand = lipstick.Brand,
                Price = lipstick.Price,
                Volume = lipstick.Volume,
                QuantityGeneralVolume = lipstick.QuantityGeneralVolume,
                QuantityBottles = lipstick.QuantityBottles,
                Color = lipstick.Color,
                Description = lipstick.Description
            };
            return bllLipstick;
        }
        public static BllMascara ConvertMascaraToBllMascara(Mascara mascara)
        {
            BllMascara bllMascara = new BllMascara()
            {
                Id = mascara.Id,
                Name = mascara.Name,
                Brand = mascara.Brand,
                Price = mascara.Price,
                Volume = mascara.Volume,
                QuantityGeneralVolume = mascara.QuantityGeneralVolume,
                QuantityBottles = mascara.QuantityBottles,
                Color = mascara.Color,
                
            };
            return bllMascara;
        }
        public static BllNailBase ConvertBaseToBllBase(NailBase nailBase)
        {
            BllNailBase bllNailBase = new BllNailBase()
            {
                Id = nailBase.Id,
                Name = nailBase.Name,
                Brand = nailBase.Brand,
                Price = nailBase.Price,
                Volume = nailBase.Volume,
                QuantityGeneralVolume = nailBase.QuantityGeneralVolume,
                QuantityBottles = nailBase.QuantityBottles,
                

            };
            return bllNailBase;
        }
        public static BllNailPolish ConvertPolishToBllPolish(NailPolish nailPolish)
        {
            BllNailPolish bllNailPolish = new BllNailPolish()
            {
                Id = nailPolish.Id,
                Name = nailPolish.Name,
                Brand = nailPolish.Brand,
                Price = nailPolish.Price,
                Volume = nailPolish.Volume,
                QuantityGeneralVolume = nailPolish.QuantityGeneralVolume,
                QuantityBottles = nailPolish.QuantityBottles,
                Color= nailPolish.Color

            };
            return bllNailPolish;
        }
        public static BllNailTop ConvertTopToBllTop(NailTop nailTop)
        {
            BllNailTop bllNailTop = new BllNailTop()
            {
                Id = nailTop.Id,
                Name = nailTop.Name,
                Brand = nailTop.Brand,
                Price = nailTop.Price,
                Volume = nailTop.Volume,
                QuantityGeneralVolume = nailTop.QuantityGeneralVolume,
                QuantityBottles = nailTop.QuantityBottles,
              
            };
            return bllNailTop;
        }
        public static BllPowder ConvertPowderToBllPowder(Powder powder)
        {
            BllPowder bllPowder = new BllPowder()
            {
                Id = powder.Id,
                Name = powder.Name,
                Brand = powder.Brand,
                Price = powder.Price,
                Volume = powder.Volume,
                QuantityGeneralVolume = powder.QuantityGeneralVolume,
                QuantityBottles = powder.QuantityBottles,
                Color= powder.Color
            };
            return bllPowder;
        }
        public static BllShadows ConvertShadowToBllShadow(Shadows shadows)
        {
            BllShadows bllShadows = new BllShadows()
            {
                Id = shadows.Id,
                Name = shadows.Name,
                Brand = shadows.Brand,
                Price = shadows.Price,
                Volume = shadows.Volume,
                QuantityGeneralVolume = shadows.QuantityGeneralVolume,
                QuantityBottles = shadows.QuantityBottles,
                Color = shadows.Color
            };
            return bllShadows;
        }
        public static Staff ConvertBllStaffToStaff( BllStaff bllStaff)
        {
            DalFunction dalFunction = new DalFunction();
            Staff staff = new Staff()
            {
                Id = bllStaff.Id,
                Login = bllStaff.Login,
                Password = bllStaff.Password,
                WorkPosition = dalFunction.GetWorkPosition().Where(x => x.Id == bllStaff.WorkPosition.Id).First()
            };
            return staff;
        }



        //public static WorkPosition ConvertBllPositionToPosition(BllWorkPosition bllWork)
        //{
        //    WorkPosition workPosition = new WorkPosition()
        //    {
        //        Id= bllWork.Id,
        //        Name=bllWork.Name,

        //    };
        //    return workPosition;
        //}

     
    }
}
