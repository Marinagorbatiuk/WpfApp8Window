using System;
using System.Collections.Generic;
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

        public void DeleteFromGrid(int id)
        {
            DalFunction function = new DalFunction();
            function.Delete(id);
        }
    }



}
