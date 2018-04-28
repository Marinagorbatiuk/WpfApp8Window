using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Dal;

namespace BLL
{
    public class BusinessLogic
    {
        public BllWorkPosition BllGetUser(string Login, string Pass)
        {
          
            BllWorkPosition position = null;

            DalFunction function = new DalFunction();
            Staff staff = function.GetUser(Login, Pass);
            
           // string name = staff?.Login ?? "gvgv";
            if(staff!=null)
            {
                position = Convertation.ConvertPositionToBllPosition(function.GetOneWorkPosition(staff.Id));
            }


            return position;
        }

        public List<BllWorkPosition> GetListPositions ()
        {
            DalFunction function = new DalFunction();
            List<BllWorkPosition> positions = new List<BllWorkPosition>();
           foreach(var item in function.GetWorkPosition())
            {
                positions.Add(Convertation.ConvertPositionToBllPosition(item));
            }
          
            return positions;          
        }

        public List<BllShampoo> GetListShampoo()
        {
            DalFunction function = new DalFunction();
            List<BllShampoo> bllShampoosList = new List<BllShampoo>();
            //foreach (var item in function.GetShampoo())
            //{
            //    bllShampoosList.Add(Convertation.ConvertShampooToBllShampoo(item));
            //}
            bllShampoosList = function.GetShampoo().Select(x => Convertation.ConvertShampooToBllShampoo(x)).ToList();

            return bllShampoosList;
        }

        public List<BllBalsam> GetListBalsam()
        {
            DalFunction function = new DalFunction();
            List<BllBalsam> bllBalsamList = new List<BllBalsam>();

            bllBalsamList = function.GetBalsam().Select(x => Convertation.ConvertBalsamToBllBalsam(x)).ToList();

            return bllBalsamList;
        }
        public List<BllColor> GetListColor()
        {
            DalFunction function = new DalFunction();
            List<BllColor> bllBaColorList = new List<BllColor>();

            bllBaColorList = function.GetColor().Select(x => Convertation.ConvertColorToBllColor(x)).ToList();

            return bllBaColorList;
        }
        public List<BllFoundation> GetListFoundation()
        {
            DalFunction function = new DalFunction();
            List<BllFoundation> bllBaFoundationList = new List<BllFoundation>();

            bllBaFoundationList = function.GetFoundation().Select(x => Convertation.ConvertFoundationToBllFoundation(x)).ToList();

            return bllBaFoundationList;
        }

        public List<BllLaque> GetListLaque()
        {
            DalFunction function = new DalFunction();
            List<BllLaque> bllBaLaqueList = new List<BllLaque>();

            bllBaLaqueList = function.GetLaque().Select(x => Convertation.ConvertLaqueToBllLaque(x)).ToList();

            return bllBaLaqueList;
        }
        public List<BllLipstick> GetListLipstick()
        {
            DalFunction function = new DalFunction();
            List<BllLipstick> bllBaLipstickList = new List<BllLipstick>();

            bllBaLipstickList = function.GetLipstick().Select(x => Convertation.ConvertLipstickToBllLipstick(x)).ToList();

            return bllBaLipstickList;
        }
        public List<BllMascara> GetListMascara()
        {
            DalFunction function = new DalFunction();
            List<BllMascara> bllBaMascaraList = new List<BllMascara>();

            bllBaMascaraList = function.GetMascara().Select(x => Convertation.ConvertMascaraToBllMascara(x)).ToList();

            return bllBaMascaraList;
        }
        public List<BllNailBase> GetListNailBase()
        {
            DalFunction function = new DalFunction();
            List<BllNailBase> bllBaseList = new List<BllNailBase>();

            bllBaseList = function.GetNailBase().Select(x => Convertation.ConvertBaseToBllBase(x)).ToList();

            return bllBaseList;
        }

        public List<BllNailPolish> GetListNailPolish()
        {
            DalFunction function = new DalFunction();
            List<BllNailPolish> bllPolishList = new List<BllNailPolish>();

            bllPolishList = function.GetNailPolish().Select(x => Convertation.ConvertPolishToBllPolish(x)).ToList();

            return bllPolishList;
        }
        public List<BllNailTop> GetListNailTop()
        {
            DalFunction function = new DalFunction();
            List<BllNailTop> bllTopList = new List<BllNailTop>();

            bllTopList = function.GetNailTop().Select(x => Convertation.ConvertTopToBllTop(x)).ToList();

            return bllTopList;
        }
        public List<BllPowder> GetListPowder()
        {
            DalFunction function = new DalFunction();
            List<BllPowder> bllPowderList = new List<BllPowder>();

            bllPowderList = function.GetPowder().Select(x => Convertation.ConvertPowderToBllPowder(x)).ToList();

            return bllPowderList;
        }
        public List<BllShadows> GetListShadow()
        {
            DalFunction function = new DalFunction();
            List<BllShadows> bllShadowList = new List<BllShadows>();

            bllShadowList = function.GetShadow().Select(x => Convertation.ConvertShadowToBllShadow(x)).ToList();

            return bllShadowList;
        }
        public void DeleteFromGrid(int id)
        {
            DalFunction function = new DalFunction();
            function.Delete(id);
        }

        public List<string> AddShampoo(BllShampoo shampoo)
        {
            DalFunction function = new DalFunction();
            DTOShampoo tOShampoo = null;
            List<string> mistakes = new List<string>();
            var context = new ValidationContext(shampoo);
            var ValidationResult = new List<ValidationResult>();
            if(!Validator.TryValidateObject(shampoo,context,ValidationResult, true) )
            {
                foreach(var item in ValidationResult)
                {
                    string tmp = item.MemberNames.ToArray()[0];
                    mistakes.Add(tmp);
                }
            }
            else
            {
                tOShampoo= Convertation.ConvertToBllShampooFromDTO(shampoo);

                
            }
            return mistakes;




        }
    }



}
