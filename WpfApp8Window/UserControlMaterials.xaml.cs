using MahApps.Metro.Controls;
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
    /// Interaction logic for UserControlMaterials.xaml
    /// </summary>
    public partial class UserControlMaterials : UserControl
    {
        AddFunction addFunction = new AddFunction();
        GetFunction getFunction = new GetFunction();
        DeleteFunction deleteFunction = new DeleteFunction();
        UpdateFunction updateFunctionn = new UpdateFunction();
        public UserControlMaterials()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            foreach (var item in StockRoom.Items)
            {
                if ((item as TabItem).IsSelected)
                {
                    if ((item as TabItem).Header.ToString() == "Shampoo")
                        AddShampoo();
                    if ((item as TabItem).Header.ToString() == "Balsam")
                        AddBalsam();
                    if ((item as TabItem).Header.ToString() == "Color")
                        AddHairColor();
                    if ((item as TabItem).Header.ToString() == "Laque")
                        AddLaque();
                    if ((item as TabItem).Header.ToString() == "Powder")
                        AddPowder();
                    if ((item as TabItem).Header.ToString() == "Foundation")
                        AddFoundation();
                    if ((item as TabItem).Header.ToString() == "Shadow")
                        AddShadow();
                    if ((item as TabItem).Header.ToString() == "Lipstick")
                        AddLipstick();
                    if ((item as TabItem).Header.ToString() == "Mascara")
                        AddMascara();
                    if ((item as TabItem).Header.ToString() == "NailBase")
                        AddBase();
                    if ((item as TabItem).Header.ToString() == "NailTop")
                        AddTop();
                    if ((item as TabItem).Header.ToString() == "NailEnamel")
                        AddPolishNail();
                }
            }
        }

        private void AddShampoo()
        {
            Shampoo shampoo = new Shampoo();
            shampoo.Name = name.Text;
            shampoo.Brand = brand.Text;
            decimal.TryParse(price.Text, out decimal newPrice);
            shampoo.Price = newPrice;
            double.TryParse(volume.Text, out double newVolume);
            shampoo.Volume = newVolume;
            int.TryParse(quantity.Text, out int newQuantity);
            shampoo.QuantityBottles = newQuantity;
            shampoo.QuantityGeneralVolume = newQuantity * newVolume;
            shampoo.Description = description.Text;
            addFunction.AddShampooToDB(shampoo);
        }
        private void AddBalsam()
        {
            Balsam balsam = new Balsam();
            balsam.Name = name.Text;
            balsam.Brand = brand.Text;
            decimal.TryParse(price.Text, out decimal newPrice);
            balsam.Price = newPrice;
            double.TryParse(volume.Text, out double newVolume);
            balsam.Volume = newVolume;
            int.TryParse(quantity.Text, out int newQuantity);
            balsam.QuantityBottles = newQuantity;
            balsam.QuantityGeneralVolume = newQuantity * newVolume;
        }
        private void AddHairColor()
        {
            HairColor hairColor = new HairColor();
            hairColor.Name = name.Text;
            hairColor.Brand = brand.Text;
            decimal.TryParse(price.Text, out decimal newPrice);
            hairColor.Price = newPrice;
            double.TryParse(volume.Text, out double newVolume);
            hairColor.Volume = newVolume;
            int.TryParse(quantity.Text, out int newQuantity);
            hairColor.QuantityBottles = newQuantity;
            hairColor.QuantityGeneralVolume = newQuantity * newVolume;
            hairColor.Description = description.Text;
            hairColor.Color = color.Text;
        }
        private void AddLaque()
        {
            Laque laque = new Laque();
            laque.Name = name.Text;
            laque.Brand = brand.Text;
            decimal.TryParse(price.Text, out decimal newPrice);
            laque.Price = newPrice;
            double.TryParse(volume.Text, out double newVolume);
            laque.Volume = newVolume;
            int.TryParse(quantity.Text, out int newQuantity);
            laque.QuantityBottles = newQuantity;
            laque.QuantityGeneralVolume = newQuantity * newVolume;

        }
        private void AddFoundation()
        {
            Foundation foundation = new Foundation();

            foundation.Name = name.Text;
            foundation.Brand = brand.Text;
            decimal.TryParse(price.Text, out decimal newPrice);
            foundation.Price = newPrice;
            double.TryParse(volume.Text, out double newVolume);
            foundation.Volume = newVolume;
            int.TryParse(quantity.Text, out int newQuantity);
            foundation.QuantityBottles = newQuantity;
            foundation.QuantityGeneralVolume = newQuantity * newVolume;
            foundation.Color = color.Text;
            foundation.Description = description.Text;
        }
        private void AddPowder()
        {
            Powder powder = new Powder();
            powder.Name = name.Text;
            powder.Brand = brand.Text;
            decimal.TryParse(price.Text, out decimal newPrice);
            powder.Price = newPrice;
            double.TryParse(volume.Text, out double newVolume);
            powder.Volume = newVolume;
            int.TryParse(quantity.Text, out int newQuantity);
            powder.QuantityBottles = newQuantity;
            powder.QuantityGeneralVolume = newQuantity * newVolume;
            powder.Color = color.Text;
        }
        private void AddShadow()
        {
            Shadows shadows = new Shadows();
            shadows.Name = name.Text;
            shadows.Brand = brand.Text;
            decimal.TryParse(price.Text, out decimal newPrice);
            shadows.Price = newPrice;
            double.TryParse(volume.Text, out double newVolume);
            shadows.Volume = newVolume;
            int.TryParse(quantity.Text, out int newQuantity);
            shadows.QuantityBottles = newQuantity;
            shadows.QuantityGeneralVolume = newQuantity * newVolume;
            shadows.Color = color.Text;
        }
        private void AddMascara()
        {
            Mascara mascara = new Mascara();
            mascara.Name = name.Text;
            mascara.Brand = brand.Text;
            decimal.TryParse(price.Text, out decimal newPrice);
            mascara.Price = newPrice;
            double.TryParse(volume.Text, out double newVolume);
            mascara.Volume = newVolume;
            int.TryParse(quantity.Text, out int newQuantity);
            mascara.QuantityBottles = newQuantity;
            mascara.QuantityGeneralVolume = newQuantity * newVolume;
            mascara.Color = color.Text;
        }
        private void AddLipstick()
        {
            Lipstick lipstick = new Lipstick();
            lipstick.Name = name.Text;
            lipstick.Brand = brand.Text;
            decimal.TryParse(price.Text, out decimal newPrice);
            lipstick.Price = newPrice;
            double.TryParse(volume.Text, out double newVolume);
            lipstick.Volume = newVolume;
            int.TryParse(quantity.Text, out int newQuantity);
            lipstick.QuantityBottles = newQuantity;
            lipstick.QuantityGeneralVolume = newQuantity * newVolume;
            lipstick.Color = color.Text;
            lipstick.Description = description.Text;
        }
        private void AddTop()
        {
            NailTop top = new NailTop();
            top.Name = name.Text;
            top.Brand = brand.Text;
            decimal.TryParse(price.Text, out decimal newPrice);
            top.Price = newPrice;
            double.TryParse(volume.Text, out double newVolume);
            top.Volume = newVolume;
            int.TryParse(quantity.Text, out int newQuantity);
            top.QuantityBottles = newQuantity;
            top.QuantityGeneralVolume = newQuantity * newVolume;

        }
        private void AddBase()
        {
            NailBase nailBase = new NailBase();
            nailBase.Name = name.Text;
            nailBase.Brand = brand.Text;
            decimal.TryParse(price.Text, out decimal newPrice);
            nailBase.Price = newPrice;
            double.TryParse(volume.Text, out double newVolume);
            nailBase.Volume = newVolume;
            int.TryParse(quantity.Text, out int newQuantity);
            nailBase.QuantityBottles = newQuantity;
            nailBase.QuantityGeneralVolume = newQuantity * newVolume;
        }
        private void AddPolishNail()
        {
            NailPolish nailPolish = new NailPolish();
            nailPolish.Name = name.Text;
            nailPolish.Brand = brand.Text;
            decimal.TryParse(price.Text, out decimal newPrice);
            nailPolish.Price = newPrice;
            double.TryParse(volume.Text, out double newVolume);
            nailPolish.Volume = newVolume;
            int.TryParse(quantity.Text, out int newQuantity);
            nailPolish.QuantityBottles = newQuantity;
            nailPolish.QuantityGeneralVolume = newQuantity * newVolume;
            nailPolish.Color = color.Text;
            addFunction.AddPolishToDB(nailPolish);
            GridShadow.ItemsSource = getFunction.GetListShadow();
        }

        private void buyProduct(object sender, RoutedEventArgs e)
        {
            foreach (var item in StockRoom.Items)
            {
                if ((item as TabItem).IsSelected)
                {
                    //if ((item as TabItem).Header.ToString() == "Shampoo")
                    //{
                        Shampoo newshampoo = new Shampoo();
                         int.TryParse(quantityToBuy.Text, out int textQuantity);
                        double newQuantity = newshampoo.QuantityGeneralVolume;
                        newQuantity += textQuantity * newshampoo.Volume;
                        newshampoo.QuantityGeneralVolume = newQuantity;
                        newshampoo.QuantityBottles += textQuantity;
                        updateFunctionn.UpdateShampoo(newshampoo);
                   // }       
                }
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {

            foreach (var item in StockRoom.Items)
            {
                if ((item as TabItem).IsSelected)
                {
                    deleteFunction.DeleteProduct((((item as TabItem).Content as DataGrid).SelectedItem as Materials).Id);
                    GridShampoo.ItemsSource = getFunction.GetListShampoo();
                    GridBalsam.ItemsSource = getFunction.GetListBalsam();
                    GridColor.ItemsSource = getFunction.GetListColor();
                    GridFoundation.ItemsSource = getFunction.GetListFoundation();
                    GridLaque.ItemsSource = getFunction.GetListLaque();
                    GridLipstick.ItemsSource = getFunction.GetListLipstick();
                    GridMascara.ItemsSource = getFunction.GetListMascara();
                    GridBase.ItemsSource = getFunction.GetListNailBase();
                    GridNailEnamel.ItemsSource = getFunction.GetListNailPolish();
                    GridNailTop.ItemsSource = getFunction.GetListNailTop();
                    GridPowder.ItemsSource = getFunction.GetListPowder();
                    GridShadow.ItemsSource = getFunction.GetListShadow();
                }
            }
        }

        private void load(object sender, RoutedEventArgs e)
        {
            GridShampoo.ItemsSource = getFunction.GetListShampoo();
            GridBalsam.ItemsSource = getFunction.GetListBalsam();
            GridColor.ItemsSource = getFunction.GetListColor();
            GridFoundation.ItemsSource = getFunction.GetListFoundation();
            GridLaque.ItemsSource = getFunction.GetListLaque();
            GridLipstick.ItemsSource = getFunction.GetListLipstick();
            GridMascara.ItemsSource = getFunction.GetListMascara();
            GridBase.ItemsSource = getFunction.GetListNailBase();
            GridNailEnamel.ItemsSource = getFunction.GetListNailPolish();
            GridNailTop.ItemsSource = getFunction.GetListNailTop();
            GridPowder.ItemsSource = getFunction.GetListPowder();
            GridShadow.ItemsSource = getFunction.GetListShadow();
        }

        private void ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            (sender as NumericUpDown).Value = (int)(sender as NumericUpDown).Value;
        }
    }
}
