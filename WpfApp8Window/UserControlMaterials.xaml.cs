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
        Brush StandartBrush = null;
        public UserControlMaterials()
        {
            InitializeComponent();
            StandartBrush = price.BorderBrush;
            StandartBrush = volume.BorderBrush;
            StandartBrush = quantity.BorderBrush;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            foreach (var item in StockRoom.Items)
            {
                if ((item as TabItem).IsSelected)
                {
                    if ((item as TabItem).Header.ToString() == "Shampoo")
                    {
                        AddShampoo();
                    }
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
            load(null, null);
        }
        private void EariseValues()
        {
            name.Text = null;
            brand.Text = null;
            price.Text = null;
            volume.Text = null;
            quantity.Text = null;
            color.Text = null;
            description.Text = null;
        }
        private void AddShampoo()
        {
            Shampoo shampoo = new Shampoo();
            shampoo.Name = name.Text;
            shampoo.Brand = brand.Text;
            if (!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                price.BorderBrush = StandartBrush;
            }
            shampoo.Price = newPrice;
            if (!double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                volume.BorderBrush = StandartBrush;
            }
            shampoo.Volume = newVolume;
            if (!int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                quantity.BorderBrush = StandartBrush;
            }
            shampoo.QuantityBottles = newQuantity;
            shampoo.QuantityGeneralVolume = newQuantity * newVolume;
            shampoo.Description = description.Text;
            addFunction.AddShampooToDB(shampoo);
            EariseValues();
        }
        private void AddBalsam()
        {
            Balsam balsam = new Balsam();
            balsam.Name = name.Text;
            balsam.Brand = brand.Text;
            if (!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                price.BorderBrush = StandartBrush;
            }
            balsam.Price = newPrice;
            if (!double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                volume.BorderBrush = StandartBrush;
            }
            balsam.Volume = newVolume;
            if (!int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                quantity.BorderBrush = StandartBrush;
            }
            balsam.QuantityBottles = newQuantity;
            balsam.QuantityGeneralVolume = newQuantity * newVolume;
            addFunction.AddBalsamToDB(balsam);
            EariseValues();
        }
        private void AddHairColor()
        {
            HairColor hairColor = new HairColor();
            hairColor.Name = name.Text;
            hairColor.Brand = brand.Text;
            if (!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                price.BorderBrush = StandartBrush;
            }
            hairColor.Price = newPrice;
            if (!double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                volume.BorderBrush = StandartBrush;
            }
            hairColor.Volume = newVolume;
            if (!int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                quantity.BorderBrush = StandartBrush;
            }
            hairColor.QuantityBottles = newQuantity;
            hairColor.QuantityGeneralVolume = newQuantity * newVolume;
            hairColor.Description = description.Text;
            hairColor.Color = color.Text;
            hairColor.QuntityCount = 60;
            addFunction.AddColorToDB(hairColor);
            EariseValues();
        }
        private void AddLaque()
        {
            Laque laque = new Laque();
            laque.Name = name.Text;
            laque.Brand = brand.Text;
            if (!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                price.BorderBrush = StandartBrush;
            }
            laque.Price = newPrice;
            if (!double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                volume.BorderBrush = StandartBrush;
            }
            laque.Volume = newVolume;
            if (!int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                quantity.BorderBrush = StandartBrush;
            }
            laque.QuantityBottles = newQuantity;
            laque.QuantityGeneralVolume = newQuantity * newVolume;
            addFunction.AddLaqueToDB(laque);
            EariseValues();
        }
        private void AddFoundation()
        {
            Foundation foundation = new Foundation();

            foundation.Name = name.Text;
            foundation.Brand = brand.Text;
            if (!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                price.BorderBrush = StandartBrush;
            }
            foundation.Price = newPrice;
            if (!double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                volume.BorderBrush = StandartBrush;
            }
            foundation.Volume = newVolume;
            if (!int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                quantity.BorderBrush = StandartBrush;
            }
            foundation.QuantityBottles = newQuantity;
            foundation.QuantityGeneralVolume = newQuantity * newVolume;
            foundation.Color = color.Text;
            foundation.Description = description.Text;
            addFunction.AddFoundationToDB(foundation);
            EariseValues();
        }
        private void AddPowder()
        {
            Powder powder = new Powder();
            powder.Name = name.Text;
            powder.Brand = brand.Text;
            if (!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                price.BorderBrush = StandartBrush;
            }
            powder.Price = newPrice;
            if (!double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                volume.BorderBrush = StandartBrush;
            }
            powder.Volume = newVolume;
            if (!int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                quantity.BorderBrush = StandartBrush;
            }
            powder.QuantityBottles = newQuantity;
            powder.QuantityGeneralVolume = newQuantity * newVolume;
            powder.Color = color.Text;
            addFunction.AddPowderToDB(powder);
            EariseValues();
        }
        private void AddShadow()
        {
            Shadows shadows = new Shadows();
            shadows.Name = name.Text;
            shadows.Brand = brand.Text;
            if (!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                price.BorderBrush = StandartBrush;
            }
            shadows.Price = newPrice;
            if (!double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                volume.BorderBrush = StandartBrush;
            }
            shadows.Volume = newVolume;
            if (!int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                quantity.BorderBrush = StandartBrush;
            }
            shadows.QuantityBottles = newQuantity;
            shadows.QuantityGeneralVolume = newQuantity * newVolume;
            shadows.Color = color.Text;
            addFunction.AddShadowToDB(shadows);
            EariseValues();
        }
        private void AddMascara()
        {
            Mascara mascara = new Mascara();
            mascara.Name = name.Text;
            mascara.Brand = brand.Text;
            if (!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                price.BorderBrush = StandartBrush;
            }
            mascara.Price = newPrice;
            if (!double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                volume.BorderBrush = StandartBrush;
            }
            mascara.Volume = newVolume;
            if (!int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                quantity.BorderBrush = StandartBrush;
            }
            mascara.QuantityBottles = newQuantity;
            mascara.QuantityGeneralVolume = newQuantity * newVolume;
            mascara.Color = color.Text;
            addFunction.AddMascaraToDB(mascara);
            EariseValues();
        }
        private void AddLipstick()
        {
            Lipstick lipstick = new Lipstick();
            lipstick.Name = name.Text;
            lipstick.Brand = brand.Text;
            if (!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                price.BorderBrush = StandartBrush;
            }
            lipstick.Price = newPrice;
            if (!double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                volume.BorderBrush = StandartBrush;
            }
            lipstick.Volume = newVolume;
            if (!int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                quantity.BorderBrush = StandartBrush;
            }
            lipstick.QuantityBottles = newQuantity;
            lipstick.QuantityGeneralVolume = newQuantity * newVolume;
            lipstick.Color = color.Text;
            lipstick.Description = description.Text;
            addFunction.AddLipstickToDB(lipstick);
            EariseValues();
        }
        private void AddTop()
        {
            NailTop top = new NailTop();
            top.Name = name.Text;
            top.Brand = brand.Text;
            if (!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                price.BorderBrush = StandartBrush;
            }
            top.Price = newPrice;
            if (!double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                volume.BorderBrush = StandartBrush;
            }
            top.Volume = newVolume;
            if (!int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                quantity.BorderBrush = StandartBrush;
            }
            top.QuantityBottles = newQuantity;
            top.QuantityGeneralVolume = newQuantity * newVolume;
            addFunction.AddTopToDB(top);
            EariseValues();
        }
        private void AddBase()
        {
            NailBase nailBase = new NailBase();
            nailBase.Name = name.Text;
            nailBase.Brand = brand.Text;
            if (!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                price.BorderBrush = StandartBrush;
            }
            nailBase.Price = newPrice;
            if (!double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                volume.BorderBrush = StandartBrush;
            }
            nailBase.Volume = newVolume;
            if (!int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                quantity.BorderBrush = StandartBrush;
            }
            nailBase.QuantityBottles = newQuantity;
            nailBase.QuantityGeneralVolume = newQuantity * newVolume;
            addFunction.AddBaseToDB(nailBase);
            EariseValues();
        }
        private void AddPolishNail()
        {
            NailPolish nailPolish = new NailPolish();
            nailPolish.Name = name.Text;
            nailPolish.Brand = brand.Text;
            if (!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                price.BorderBrush = StandartBrush;
            }
            nailPolish.Price = newPrice;
            if (!double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                volume.BorderBrush = StandartBrush;
            }
            nailPolish.Volume = newVolume;
            if (!int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                quantity.BorderBrush = StandartBrush;
            }
            nailPolish.QuantityBottles = newQuantity;
            nailPolish.QuantityGeneralVolume = newQuantity * newVolume;
            nailPolish.Color = color.Text;
            addFunction.AddPolishToDB(nailPolish);
            EariseValues();
        }

        private void buyProduct(object sender, RoutedEventArgs e)
        {
            foreach (var item in StockRoom.Items)
            {
                if ((item as TabItem).IsSelected)
                {
                    if (((item as TabItem).Content as DataGrid).SelectedIndex >= 0)
                    {
                        if (quantityToBuy.Value != null)
                        {
                            Materials materials = ((item as TabItem).Content as DataGrid).SelectedItem as Materials;
                            int Id = materials.Id;
                            double quantityGeneral = materials.QuantityGeneralVolume + (materials.Volume * (double)quantityToBuy.Value);
                            int quantityBottles = materials.QuantityBottles + (int)quantityToBuy.Value;
                            getFunction.GetChangedQuantity(quantityBottles, quantityGeneral, Id);
                            load(null, null);
                        }
                    }
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
                    load(null, null);
                }
            }
        }
        private void load(object sender, RoutedEventArgs e)
        {
            GridShampoo.ItemsSource = null;
            GridShampoo.ItemsSource = getFunction.GetListShampoo();
            GridBalsam.ItemsSource = null;
            GridBalsam.ItemsSource = getFunction.GetListBalsam();
            GridColor.ItemsSource = null;
            GridColor.ItemsSource = getFunction.GetListColor();
            GridFoundation.ItemsSource = null;
            GridFoundation.ItemsSource = getFunction.GetListFoundation();
            GridLaque.ItemsSource = null;
            GridLaque.ItemsSource = getFunction.GetListLaque();
            GridLipstick.ItemsSource = null;
            GridLipstick.ItemsSource = getFunction.GetListLipstick();
            GridMascara.ItemsSource = null;
            GridMascara.ItemsSource = getFunction.GetListMascara();
            GridBase.ItemsSource = null;
            GridBase.ItemsSource = getFunction.GetListNailBase();
            GridNailEnamel.ItemsSource = null;
            GridNailEnamel.ItemsSource = getFunction.GetListNailPolish();
            GridNailTop.ItemsSource = null;
            GridNailTop.ItemsSource = getFunction.GetListNailTop();
            GridPowder.ItemsSource = null;
            GridPowder.ItemsSource = getFunction.GetListPowder();
            GridShadow.ItemsSource = null;
            GridShadow.ItemsSource = getFunction.GetListShadow();
            quantityToBuy.Value = 1;
        }

        private void ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            (sender as NumericUpDown).Value = (int)(sender as NumericUpDown).Value;
        }
    }
}
