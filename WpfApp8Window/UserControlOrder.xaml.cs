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
using Dal;
namespace WpfApp8Window
{
    /// <summary>
    /// Interaction logic for UserControlOrder.xaml
    /// </summary>
    public partial class UserControlOrder : UserControl
    {
        GetFunction getFunction = new GetFunction();
        public UserControlOrder()
        {
            InitializeComponent();

        }


        private void load(object sender, RoutedEventArgs e)
        {
            ShampooGrid.ItemsSource = getFunction.GetListShampoo();
            BalsamGrid.ItemsSource = getFunction.GetListBalsam();
            LaqueGrid.ItemsSource = getFunction.GetListLaque();
            ColorGrid.ItemsSource = getFunction.GetListColor();
            FoundationGrid.ItemsSource = getFunction.GetListFoundation();
            PowderGrid.ItemsSource = getFunction.GetListPowder();
            ShadowGrid.ItemsSource = getFunction.GetListShadow();
            MascaraGrid.ItemsSource = getFunction.GetListMascara();
            LipstickGrid.ItemsSource = getFunction.GetListLipstick();
            TopGrid.ItemsSource = getFunction.GetListNailTop();
            BaseGrid.ItemsSource = getFunction.GetListNailBase();
            PolishGrid.ItemsSource = getFunction.GetListNailPolish();
        }

        private void OkClick(object sender, RoutedEventArgs e)
        {
            List<Materials> materials = new List<Materials>();
            materials.Add(ShampooGrid.SelectedItem as Materials);
               MaterialsToOrder.ItemsSource = materials;
            //foreach (var item in materials)
            //{
            //    item.Add(ShampooGrid.SelectedItem as Materials);
            //    MaterialsToOrder.ItemsSource = item;
            //}



            //foreach (var item in Shampoo.Items)
            //{
            //    if ((item as TabItem).IsSelected)
            //    {

            //    }
            //}


            //foreach (var item in Shampoo.Items)
            //{
            //   MessageBox.Show("Test1");
            //    if ((item as TabItem).IsSelected)
            //    {
            //        MessageBox.Show("Test2");
            //        if (((item as TabItem).Content as DataGrid).SelectedIndex >= 0)
            //        {
            //            MessageBox.Show("Test3");
            //            materials.Add(item as Shampoo);
            //            // MaterialsToOrder.DataContext = materials;
            //            MaterialsToOrder.ItemsSource = materials;
            //        }
            //    }
            //}

        }
        private void cut_Checked(object sender, RoutedEventArgs e)
        {

            ShampooGrid.IsEnabled = true;
            BalsamGrid.IsEnabled = true;
            LaqueGrid.IsEnabled = true;

        }

        private void coloring_Checked(object sender, RoutedEventArgs e)
        {
            ShampooGrid.IsEnabled = true;
            BalsamGrid.IsEnabled = true;
            LaqueGrid.IsEnabled = true;
            ColorGrid.IsEnabled = true;
        }

        private void manicure_Checked(object sender, RoutedEventArgs e)
        {
            TopGrid.IsEnabled = true;
            BaseGrid.IsEnabled = true;
            PolishGrid.IsEnabled = true;
        }

        private void makeup_Checked(object sender, RoutedEventArgs e)
        {
            FoundationGrid.IsEnabled = true;
            PowderGrid.IsEnabled = true;
            ShadowGrid.IsEnabled = true;
            MascaraGrid.IsEnabled = true;
            LipstickGrid.IsEnabled = true;
        }
    }
}
