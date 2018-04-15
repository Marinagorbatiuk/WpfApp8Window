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
                    MessageBox.Show(((item as TabItem).Content as DataGrid).SelectedItem.ToString());
                    BusinessLogic bll = new BusinessLogic();
                    bll.DeleteFromGrid ((((item as TabItem).Content as DataGrid).SelectedItem as BllMaterials).Id);
                    GridShampoo.ItemsSource = bll.GetListShampoo();
                    GridShampoo.Columns[0].DisplayIndex = GridShampoo.Columns.Count() - 1;
                    
                }
            }
        }

        private void load(object sender, RoutedEventArgs e)
        {
            BusinessLogic bll = new BusinessLogic();
            //bll.GetListShampoo();
            GridShampoo.ItemsSource = bll.GetListShampoo();
            GridShampoo.Columns[0].DisplayIndex = GridShampoo.Columns.Count() - 1;
            //GridShampoo.Columns.Count() - 1;
            
        }
    }
}
