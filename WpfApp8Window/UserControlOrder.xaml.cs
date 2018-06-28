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
        AddFunction addFunction = new AddFunction();
        GetFunction getFunction = new GetFunction();
        public List<WriteOffMaterials> materialsWritingoff = new List<WriteOffMaterials>();
        public UserControlOrder()
        {
            InitializeComponent();

        }
        private void load(object sender, RoutedEventArgs e)
        {
            MaterialsToOrder.ItemsSource = null;
            MaterialsToOrder.ItemsSource = materialsWritingoff;
            ShampooGrid.ItemsSource = null;
            ShampooGrid.ItemsSource = getFunction.GetListShampoo();
            BalsamGrid.ItemsSource = null;
            BalsamGrid.ItemsSource = getFunction.GetListBalsam();
            LaqueGrid.ItemsSource = null;
            LaqueGrid.ItemsSource = getFunction.GetListLaque();
            ColorGrid.ItemsSource = null;
            ColorGrid.ItemsSource = getFunction.GetListColor();
            FoundationGrid.ItemsSource = null;
            FoundationGrid.ItemsSource = getFunction.GetListFoundation();
            PowderGrid.ItemsSource = null;
            PowderGrid.ItemsSource = getFunction.GetListPowder();
            ShadowGrid.ItemsSource = null;
            ShadowGrid.ItemsSource = getFunction.GetListShadow();
            MascaraGrid.ItemsSource = null;
            MascaraGrid.ItemsSource = getFunction.GetListMascara();
            LipstickGrid.ItemsSource = null;
            LipstickGrid.ItemsSource = getFunction.GetListLipstick();
            TopGrid.ItemsSource = null;
            TopGrid.ItemsSource = getFunction.GetListNailTop();
            BaseGrid.ItemsSource = null;
            BaseGrid.ItemsSource = getFunction.GetListNailBase();
            PolishGrid.ItemsSource = null;
            PolishGrid.ItemsSource = getFunction.GetListNailPolish();
        }
        private void OkClick(object sender, RoutedEventArgs e)
        {           

            if (ShampooGrid.SelectedIndex > -1)
            {
                WritingDownMaterials(ShampooGrid.SelectedItem as Material);
            }
            if (BalsamGrid.SelectedIndex > -1)
            {
                WritingDownMaterials(BalsamGrid.SelectedItem as Material);
            }
            if (ColorGrid.SelectedIndex > -1)
            {
                WritingDownMaterials(ColorGrid.SelectedItem as Material);
            }
            if (LaqueGrid.SelectedIndex > -1)
            {
                WritingDownMaterials(LaqueGrid.SelectedItem as Material);
            }
            if (FoundationGrid.SelectedIndex > -1)
            {
                WritingDownMaterials(FoundationGrid.SelectedItem as Material);
            }
            if (PowderGrid.SelectedIndex > -1)
            {
                WritingDownMaterials(PowderGrid.SelectedItem as Material);
            }
            if (ShadowGrid.SelectedIndex > -1)
            {
                WritingDownMaterials(ShadowGrid.SelectedItem as Material);
            }
            if (MascaraGrid.SelectedIndex > -1)
            {
                WritingDownMaterials(MascaraGrid.SelectedItem as Material);
            }
            if (LipstickGrid.SelectedIndex > -1)
            {
                WritingDownMaterials(LipstickGrid.SelectedItem as Material);
            }
            if (BaseGrid.SelectedIndex > -1)
            {
                WritingDownMaterials(BaseGrid.SelectedItem as Material);
            }
            if (PolishGrid.SelectedIndex > -1)
            {
                WritingDownMaterials(PolishGrid.SelectedItem as Material);
            }
            if (TopGrid.SelectedIndex > -1)
            {
                WritingDownMaterials(TopGrid.SelectedItem as Material);
            }
            CleanGrid();
            MaterialsToOrder.ItemsSource = null;
            MaterialsToOrder.ItemsSource = materialsWritingoff;
        }
        private void WritingDownMaterials(Material material)
        {

            WriteOffMaterials offMaterials = materialsWritingoff.FirstOrDefault(x => x.Material.Id == material.Id);
            if (offMaterials != null)
            {
                offMaterials.UsedQuantity += 1;
            }
            else
            {
                offMaterials = new WriteOffMaterials()
                {
                    UsedQuantity = 1,
                    Material = material
                };
                materialsWritingoff.Add(offMaterials);
            }

        }
        private void CleanGrid()
        {
            ShampooGrid.SelectedItems.Clear();
            BalsamGrid.SelectedItems.Clear();
            LaqueGrid.SelectedItems.Clear();
            ColorGrid.SelectedItems.Clear();
            FoundationGrid.SelectedItems.Clear();
            PowderGrid.SelectedItems.Clear();
            ShadowGrid.SelectedItems.Clear();
            MascaraGrid.SelectedItems.Clear();
            LipstickGrid.SelectedItems.Clear();
            BaseGrid.SelectedItems.Clear();
            PolishGrid.SelectedItems.Clear();
            TopGrid.SelectedItems.Clear();
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
            LackOfMaterials ofMaterials = new LackOfMaterials();
            List<string> notEnougtMaterials = addFunction.WritingOff(materialsWritingoff);
            string lackMaterials = string.Empty;
            notEnougtMaterials.Select(x => lackMaterials += x + "\n").ToArray();
            materialsWritingoff.Clear();
            ofMaterials.materialsLack.Text = lackMaterials;
            if (notEnougtMaterials.Count != 0)
            {
               ofMaterials.Show();
            }
            load(null, null);
        }
        private void DeleteButton(object sender, RoutedEventArgs e)
        {
            if (MaterialsToOrder.SelectedIndex > -1)
            {
                materialsWritingoff.Remove(MaterialsToOrder.SelectedItem as WriteOffMaterials);
                load(null, null);
            }
        }

        private void focus(object sender, RoutedEventArgs e)
        {
            (sender as DataGrid).SelectedIndex = -1;
        }
    }
}
