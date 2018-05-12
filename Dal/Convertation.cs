using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.ServiceReference1;
namespace Dal
{
    class Convertation
    {
        public static Staff ConvertStaffToDal(StaffWCF wcfStaff)
        {
            Staff staff = new Staff()
            {
                Login = wcfStaff.Login,
                Password = wcfStaff.Password,

                Id = wcfStaff.Id,
                WorkPosition = new WorkPosition
                {
                    Name = wcfStaff.WorkPosition.Name,
                    Id = wcfStaff.WorkPosition.Id
                },
            };

            return staff;
        }
        public static StaffWCF ConvertStaffToWCF(Staff staff)
        {
            StaffWCF wcfStaff = new StaffWCF()
            {
                Login = staff.Login,
                Password = staff.Password,
                WorkPosition = new WorkPositionWCF
                {
                    Id = staff.WorkPosition.Id,
                    Name = staff.WorkPosition.Name
                }
            };

            return wcfStaff;
        }
        public static WorkPosition ConvertPositionToDal(WorkPositionWCF wcfWorkPosition)
        {
            WorkPosition workPosition = new WorkPosition()
            {
                Name = wcfWorkPosition.Name,
                Id = wcfWorkPosition.Id,

            };

            return workPosition;
        }
        public static WorkPositionWCF ConvertPositionToWCF(WorkPosition workPosition)
        {
            WorkPositionWCF wcfWorkPosition = new WorkPositionWCF()
            {
                Name = workPosition.Name,
                Id = workPosition.Id
            };
            return wcfWorkPosition;
        }
        public static ServicesWCF ConvertServicesToWCF(Services service)
        {
            ServicesWCF wcfServices = new ServicesWCF()
            {
                Name = service.Name,
                Price = service.Price,
                Id = service.Id,
                //BllMaterials= dTODalService.Id
            };
            return wcfServices;
        }
        public static Services ConvertServicesToDal(ServicesWCF wcfServices)
        {
            Services service = new Services()
            {
                Name = wcfServices.Name,
                Price = wcfServices.Price,
                Id = wcfServices.Id,
                //  Materials=bllServices.BllMaterials
            };
            return service;
        }
        public static BalsamWCF ConvertBalsamToWCF(Balsam  Balsam)
        {
            BalsamWCF wcfBalsam = new BalsamWCF()
            {
                Name = Balsam.Name,
                Brand = Balsam.Brand,
                Price = Balsam.Price,
                QuantityBottles = Balsam.QuantityBottles,
                QuantityGeneralVolume = Balsam.QuantityGeneralVolume,
                Volume = Balsam.Volume,
                Id = Balsam.Id,
            };
            return wcfBalsam;
        }
        public static Balsam ConvertBalsamToDAL(BalsamWCF wcfBalsam)
        {
            Balsam balsam = new Balsam()
            {
                Name = wcfBalsam.Name,
                Brand = wcfBalsam.Brand,
                Price = wcfBalsam.Price,
                QuantityBottles = wcfBalsam.QuantityBottles,
                QuantityGeneralVolume = wcfBalsam.QuantityGeneralVolume,
                Volume = wcfBalsam.Volume,
                Id = wcfBalsam.Id
            };
            return balsam;
        }
        public static ColorWCF ConvertColorToWCF(HairColor color)
        {
            ColorWCF wcfColor = new ColorWCF()
            {
                Id = color.Id,
                Name = color.Name,
                Brand = color.Brand,
                Price = color.Price,
                Color = color.Color,
                Volume = color.Volume,
                QuantityBottles = color.QuantityBottles,
                QuantityGeneralVolume = color.QuantityGeneralVolume,
                Description = color.Description,
                //BllServices=dTOColor.Service
            };
            return wcfColor;
        }
        public static HairColor ConvertColorToDal(ColorWCF wcfColor)
        {
            HairColor color = new HairColor()
            {
                Id = wcfColor.Id,
                Name = wcfColor.Name,
                Brand = wcfColor.Brand,
                Price = wcfColor.Price,
                Color = wcfColor.Color,
                Volume = wcfColor.Volume,
                QuantityBottles = wcfColor.QuantityBottles,
                QuantityGeneralVolume = wcfColor.QuantityGeneralVolume,
                Description = wcfColor.Description,
            };
            return color;
        }
        public static FoundationWCF ConvertFoundationToWCF(Foundation foundation)
        {
            FoundationWCF wcfFoundation = new FoundationWCF()
            {
                Id = foundation.Id,
                Name = foundation.Name,
                Brand = foundation.Brand,
                Price = foundation.Price,
                Color = foundation.Color,
                Volume = foundation.Volume,
                QuantityBottles = foundation.QuantityBottles,
                QuantityGeneralVolume = foundation.QuantityGeneralVolume,
                Description = foundation.Description,
            };
            return wcfFoundation;
        }
        public static Foundation ConvertFoundationToDal(FoundationWCF wcfFoundation)
        {
            Foundation foundation = new Foundation()
            {
                Id = wcfFoundation.Id,
                Name = wcfFoundation.Name,
                Brand = wcfFoundation.Brand,
                Price = wcfFoundation.Price,
                Color = wcfFoundation.Color,
                Volume = wcfFoundation.Volume,
                QuantityBottles = wcfFoundation.QuantityBottles,
                QuantityGeneralVolume = wcfFoundation.QuantityGeneralVolume,
                Description = wcfFoundation.Description,
            };
            return foundation;
        }
        public static LaqueWCF ConvertLaqueToWCF(Laque laque)
        {
            LaqueWCF wcfLaque = new LaqueWCF()
            {
                Id = laque.Id,
                Name = laque.Name,
                Brand = laque.Brand,
                Price = laque.Price,
                Volume = laque.Volume,
                QuantityBottles = laque.QuantityBottles,
                QuantityGeneralVolume = laque.QuantityGeneralVolume,

            };

            return wcfLaque;
        }
        public static Laque ConvertLaqueToDal(LaqueWCF wcfLaque)
        {
            Laque laque = new Laque()
            {
                Id = wcfLaque.Id,
                Name = wcfLaque.Name,
                Brand = wcfLaque.Brand,
                Price = wcfLaque.Price,
                Volume = wcfLaque.Volume,
                QuantityBottles = wcfLaque.QuantityBottles,
                QuantityGeneralVolume = wcfLaque.QuantityGeneralVolume,
            };
            return laque;
        }
        public static LipstickWCF ConvertLipstickToWCF(Lipstick lipstick)
        {
            LipstickWCF wcfLipstick = new LipstickWCF()
            {
                Id = lipstick.Id,
                Name = lipstick.Name,
                Brand = lipstick.Brand,
                Price = lipstick.Price,
                Color = lipstick.Color,
                Volume = lipstick.Volume,
                QuantityBottles = lipstick.QuantityBottles,
                QuantityGeneralVolume = lipstick.QuantityGeneralVolume,
                Description = lipstick.Description,
            };

            return wcfLipstick;
        }
        public static Lipstick ConvertLipstickToDal(LipstickWCF wcfLipstick)
        {
            Lipstick lipstick = new Lipstick()
            {
                Id = wcfLipstick.Id,
                Name = wcfLipstick.Name,
                Brand = wcfLipstick.Brand,
                Price = wcfLipstick.Price,
                Color = wcfLipstick.Color,
                Volume = wcfLipstick.Volume,
                QuantityBottles = wcfLipstick.QuantityBottles,
                QuantityGeneralVolume = wcfLipstick.QuantityGeneralVolume,
                Description = wcfLipstick.Description,
            };
            return lipstick;
        }
        public static MascaraWCF ConvertMascaraToWCF(Mascara mascara)
        {
            MascaraWCF wcfmascara = new MascaraWCF()
            {
                Id = mascara.Id,
                Name = mascara.Name,
                Brand = mascara.Brand,
                Price = mascara.Price,
                Color = mascara.Color,
                Volume = mascara.Volume,
                QuantityBottles = mascara.QuantityBottles,
                QuantityGeneralVolume = mascara.QuantityGeneralVolume,
            };
            return wcfmascara;
        }
        public static Mascara ConvertMascaraToDal(MascaraWCF wcfMascara)
        {
            Mascara mascara = new Mascara()
            {
                Id = wcfMascara.Id,
                Name = wcfMascara.Name,
                Brand = wcfMascara.Brand,
                Price = wcfMascara.Price,
                Color = wcfMascara.Color,
                Volume = wcfMascara.Volume,
                QuantityBottles = wcfMascara.QuantityBottles,
                QuantityGeneralVolume = wcfMascara.QuantityGeneralVolume,
            };
            return mascara;
        }
        public static NailBaseWCF ConvertBaseToWCf(NailBase nailBase)
        {
            NailBaseWCF wcfNailBase = new NailBaseWCF()
            {
                Id = nailBase.Id,
                Name = nailBase.Name,
                Brand = nailBase.Brand,
                Price = nailBase.Price,
                Volume = nailBase.Volume,
                QuantityBottles = nailBase.QuantityBottles,
                QuantityGeneralVolume = nailBase.QuantityGeneralVolume,
            };

            return wcfNailBase;
        }
        public static NailBase ConvertBaseToDAL(NailBaseWCF wcfNailBase)
        {
            NailBase nailBase = new NailBase()
            {
                Id = wcfNailBase.Id,
                Name = wcfNailBase.Name,
                Brand = wcfNailBase.Brand,
                Price = wcfNailBase.Price,
                Volume = wcfNailBase.Volume,
                QuantityBottles = wcfNailBase.QuantityBottles,
                QuantityGeneralVolume = wcfNailBase.QuantityGeneralVolume,
            };
            return nailBase;
        }
        public static NailPolishWCF ConvertPolishToWCF(NailPolish polish)
        {
            NailPolishWCF wcfNailPolish = new NailPolishWCF()
            {
                Id = polish.Id,
                Name = polish.Name,
                Brand = polish.Brand,
                Price = polish.Price,
                Volume = polish.Volume,
                QuantityBottles = polish.QuantityBottles,
                QuantityGeneralVolume = polish.QuantityGeneralVolume,
                Color = polish.Color
            };
            return wcfNailPolish;
        }
        public static NailPolish ConvertPolishToDal(NailPolishWCF wcfNailPolish)
        {
            NailPolish polish = new NailPolish()
            {
                Id = wcfNailPolish.Id,
                Name = wcfNailPolish.Name,
                Brand = wcfNailPolish.Brand,
                Price = wcfNailPolish.Price,
                Volume = wcfNailPolish.Volume,
                QuantityBottles = wcfNailPolish.QuantityBottles,
                QuantityGeneralVolume = wcfNailPolish.QuantityGeneralVolume,
                Color = wcfNailPolish.Color
            };
            return polish;
        }
        public static NailTopWCF ConvertTopTOWcf(NailTop nailTop)
        {
            NailTopWCF topWCF = new NailTopWCF()
            {
                Id = nailTop.Id,
                Name = nailTop.Name,
                Brand = nailTop.Brand,
                Price = nailTop.Price,
                Volume = nailTop.Volume,
                QuantityBottles = nailTop.QuantityBottles,
                QuantityGeneralVolume = nailTop.QuantityGeneralVolume,
            };

            return topWCF;
        }
        public static NailTop ConvertTopToDal(NailTopWCF wcfNailTop)
        {
            NailTop nailTop = new NailTop()
            {
                Id = wcfNailTop.Id,
                Name = wcfNailTop.Name,
                Brand = wcfNailTop.Brand,
                Price = wcfNailTop.Price,
                Volume = wcfNailTop.Volume,
                QuantityBottles = wcfNailTop.QuantityBottles,
                QuantityGeneralVolume = wcfNailTop.QuantityGeneralVolume,
            };
            return nailTop;
        }
        public static PowderWCF ConvertPowderToWCf(Powder powder)
        {
            PowderWCF wcfPowder = new PowderWCF()
            {
                Id = powder.Id,
                Name = powder.Name,
                Brand = powder.Brand,
                Price = powder.Price,
                Volume = powder.Volume,
                QuantityBottles = powder.QuantityBottles,
                QuantityGeneralVolume = powder.QuantityGeneralVolume,
                Color = powder.Color
            };
            return wcfPowder;
        }
        public static Powder ConvertPowderToDAL(PowderWCF wcfPowder)
        {
            Powder powder = new Powder()
            {
                Id = wcfPowder.Id,
                Name = wcfPowder.Name,
                Brand = wcfPowder.Brand,
                Price = wcfPowder.Price,
                Volume = wcfPowder.Volume,
                QuantityBottles = wcfPowder.QuantityBottles,
                QuantityGeneralVolume = wcfPowder.QuantityGeneralVolume,
                Color = wcfPowder.Color
            };
            return powder;
        }
        public static ShadowsWCF ConvertShadowToWCF(Shadows shadows)
        {
            ShadowsWCF wcfShadows = new ShadowsWCF()
            {
                Id = shadows.Id,
                Name = shadows.Name,
                Brand = shadows.Brand,
                Price = shadows.Price,
                Volume = shadows.Volume,
                QuantityBottles = shadows.QuantityBottles,
                QuantityGeneralVolume = shadows.QuantityGeneralVolume,
                Color = shadows.Color
            };
            return wcfShadows;
        }
        public static Shadows ConvertShadowToDAl(ShadowsWCF wcfShadows)
        {
            Shadows shadows = new Shadows()
            {
                Id = wcfShadows.Id,
                Name = wcfShadows.Name,
                Brand = wcfShadows.Brand,
                Price = wcfShadows.Price,
                Volume = wcfShadows.Volume,
                QuantityBottles = wcfShadows.QuantityBottles,
                QuantityGeneralVolume = wcfShadows.QuantityGeneralVolume,
                Color = wcfShadows.Color,
            };
            return shadows;
        }
        public static ShampooWCF ConvertShampoToWcf(Shampoo shampoo)
        {
            ShampooWCF wcfShampoo = new ShampooWCF()
            {
                Id = shampoo.Id,
                Name = shampoo.Name,
                Brand = shampoo.Brand,
                Price = shampoo.Price,
                Volume = shampoo.Volume,
                QuantityBottles = shampoo.QuantityBottles,
                QuantityGeneralVolume = shampoo.QuantityGeneralVolume,
                Description = shampoo.Description
            };
            return wcfShampoo;
        }
        public static Shampoo ConvertShampooToDal(ShampooWCF wcfShampoo)
        {
            Shampoo shampoo = new Shampoo()
            {
                Id = wcfShampoo.Id,
                Name = wcfShampoo.Name,
                Brand = wcfShampoo.Brand,
                Price = wcfShampoo.Price,
                Volume = wcfShampoo.Volume,
                QuantityBottles = wcfShampoo.QuantityBottles,
                QuantityGeneralVolume = wcfShampoo.QuantityGeneralVolume,
                Description = wcfShampoo.Description
            };
            return shampoo;
        }
        public static Materials ConvertWcfMaterials(MaterialsWCF tmpMaterial)
        {
            Materials getmaterial = null;
            if (tmpMaterial is BalsamWCF)
            {
                getmaterial = ConvertBalsamToDAL(tmpMaterial as BalsamWCF);
            }
            else if (tmpMaterial is ShampooWCF)
            {
                getmaterial = ConvertShampooToDal(tmpMaterial as ShampooWCF);
            }
            else if (tmpMaterial is LaqueWCF)
            {
                getmaterial = ConvertLaqueToDal(tmpMaterial as LaqueWCF);
            }
            else if (tmpMaterial is ColorWCF)
            {
                getmaterial = ConvertColorToDal(tmpMaterial as ColorWCF);
            }
            else if (tmpMaterial is PowderWCF)
            {
                getmaterial = ConvertPowderToDAL(tmpMaterial as PowderWCF);
            }
            else if (tmpMaterial is FoundationWCF)
            {
                getmaterial = ConvertFoundationToDal(tmpMaterial as FoundationWCF);
            }
            else if (tmpMaterial is MascaraWCF)
            {
                getmaterial = ConvertMascaraToDal(tmpMaterial as MascaraWCF);
            }
            else if (tmpMaterial is LipstickWCF)
            {
                getmaterial = ConvertLipstickToDal(tmpMaterial as LipstickWCF);
            }
            else if (tmpMaterial is ShadowsWCF)
            {
                getmaterial = ConvertShadowToDAl(tmpMaterial as ShadowsWCF);
            }
            else if (tmpMaterial is NailBaseWCF)
            {
                getmaterial = ConvertBaseToDAL(tmpMaterial as NailBaseWCF);
            }
            else if (tmpMaterial is NailTopWCF)
            {
                getmaterial = ConvertTopToDal(tmpMaterial as NailTopWCF);
            }
            else if (tmpMaterial is NailPolishWCF)
            {
                getmaterial = ConvertPolishToDal(tmpMaterial as NailPolishWCF);
            }
            return getmaterial;
        }

    }
}
