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
        List<Materials> materials = new List<Materials>();
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

            materials.Add(ShampooGrid.SelectedItem as Materials);
            //materials.Add(BalsamGrid.SelectedItem as Materials);

            MaterialsToOrder.ItemsSource = null;
            MaterialsToOrder.ItemsSource = materials;

        }
        private void cut_Checked(object sender, RoutedEventArgs e)
        {
            ShampooGrid.IsEnabled = true;
            BalsamGrid.IsEnabled = true;
            LaqueGrid.IsEnabled = true;

            ColorGrid.IsEnabled = false;
            TopGrid.IsEnabled = false;
            BaseGrid.IsEnabled = false;
            PolishGrid.IsEnabled = false;
            FoundationGrid.IsEnabled = false;
            PowderGrid.IsEnabled = false;
            ShadowGrid.IsEnabled = false;
            MascaraGrid.IsEnabled = false;
            LipstickGrid.IsEnabled = false;
        }

        private void coloring_Checked(object sender, RoutedEventArgs e)
        {
            ShampooGrid.IsEnabled = true;
            BalsamGrid.IsEnabled = true;
            LaqueGrid.IsEnabled = true;
            ColorGrid.IsEnabled = true;

            TopGrid.IsEnabled = false;
            BaseGrid.IsEnabled = false;
            PolishGrid.IsEnabled = false;
            FoundationGrid.IsEnabled = false;
            PowderGrid.IsEnabled = false;
            ShadowGrid.IsEnabled = false;
            MascaraGrid.IsEnabled = false;
            LipstickGrid.IsEnabled = false;
        }

        private void manicure_Checked(object sender, RoutedEventArgs e)
        {
            TopGrid.IsEnabled = true;
            BaseGrid.IsEnabled = true;
            PolishGrid.IsEnabled = true;

            FoundationGrid.IsEnabled = false;
            PowderGrid.IsEnabled = false;
            ShadowGrid.IsEnabled = false;
            MascaraGrid.IsEnabled = false;
            LipstickGrid.IsEnabled = false;
            ShampooGrid.IsEnabled = false;
            BalsamGrid.IsEnabled = false;
            LaqueGrid.IsEnabled = false;
            ColorGrid.IsEnabled = false;
        }

        private void makeup_Checked(object sender, RoutedEventArgs e)
        {
            FoundationGrid.IsEnabled = true;
            PowderGrid.IsEnabled = true;
            ShadowGrid.IsEnabled = true;
            MascaraGrid.IsEnabled = true;
            LipstickGrid.IsEnabled = true;

            ShampooGrid.IsEnabled = false;
            BalsamGrid.IsEnabled = false;
            LaqueGrid.IsEnabled = false;
            ColorGrid.IsEnabled = false;
            ColorGrid.IsEnabled = false;
            TopGrid.IsEnabled = false;
            BaseGrid.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        //Window3 window3 = new Window3();
        //public void Back()
        //{
        //    if (order.IsPressed == false)
        //    {
        //        Dialog.IsOpen = true;
        //        if (yesButton.IsPressed)
        //        {
        //            MainWindow main = new MainWindow();
        //            App.Current.MainWindow = main;
        //            window3.Close();
        //            main.Show();
        //        }
        //        else if (noButton.IsPressed)
        //        {
        //            Dialog.IsOpen = false;
        //        }
        //    }


        //}
    }
}
