using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLL;
namespace WpfApp8Window
{
    /// <summary>
    /// Interaction logic for UserControlMaterials.xaml
    /// </summary>
    public partial class UserControlMaterials : UserControl
    {
        public UserControlMaterials()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {

        }

        private void buyProduct(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
          

            foreach (var item in StockRoom.Items)
            {
                if((item as TabItem).IsSelected)
                {
                   // MessageBox.Show(((item as TabItem).Content as DataGrid).SelectedItem.ToString());
                    BusinessLogic bll = new BusinessLogic();
                    bll.DeleteFromGrid ((((item as TabItem).Content as DataGrid).SelectedItem as BllMaterials).Id);
                    GridShampoo.ItemsSource = bll.GetListShampoo();
                    GridShampoo.Columns[0].DisplayIndex = GridShampoo.Columns.Count() - 1;
                    GridBalsam.ItemsSource = bll.GetListBalsam();
                    GridColor.ItemsSource = bll.GetListColor();
                    //GridColor.Columns[0].DisplayIndex = GridColor.Columns.Count() - 1;
                    //GridColor.Columns[0].DisplayIndex = GridColor.Columns.Count() - 1;
                    GridFoundation.ItemsSource = bll.GetListFoundation();
                    GridLaque.ItemsSource = bll.GetListLaque();
                    GridLipstick.ItemsSource = bll.GetListLipstick();
                    GridMascara.ItemsSource = bll.GetListMascara();
                    GridBase.ItemsSource = bll.GetListNailBase();
                    GridNailEnamel.ItemsSource = bll.GetListNailPolish();
                    GridNailTop.ItemsSource = bll.GetListNailTop();
                    GridPowder.ItemsSource = bll.GetListPowder();
                    GridShadow.ItemsSource = bll.GetListShadow();
                }
            }
        }

        private void load(object sender, RoutedEventArgs e)
        {
            BusinessLogic bll = new BusinessLogic();
            //bll.GetListShampoo();
            GridShampoo.ItemsSource = bll.GetListShampoo();
            GridShampoo.Columns[0].DisplayIndex = GridShampoo.Columns.Count() - 1;

            GridBalsam.ItemsSource = bll.GetListBalsam();

            GridColor.ItemsSource = bll.GetListColor();
           // GridColor.Columns[0].DisplayIndex = GridColor.Columns.Count() - 1;
           // GridColor.Columns[0].DisplayIndex = GridColor.Columns.Count() - 1;
            GridFoundation.ItemsSource = bll.GetListFoundation();
            //GridFoundation.Columns[0].DisplayIndex = GridFoundation.Columns.Count();
            GridLaque.ItemsSource = bll.GetListLaque();

            GridLipstick.ItemsSource = bll.GetListLipstick();

            GridMascara.ItemsSource = bll.GetListMascara();

            GridBase.ItemsSource = bll.GetListNailBase();

            GridNailEnamel.ItemsSource = bll.GetListNailPolish();

            GridNailTop.ItemsSource = bll.GetListNailTop();

            GridPowder.ItemsSource = bll.GetListPowder();

            GridShadow.ItemsSource = bll.GetListShadow();
            //GridShampoo.Columns.Count() - 1;
            
        }
    }
}
