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

        private void AddShampoo()
        {
       
            Shampoo shampoo = new Shampoo();
            shampoo.Name = name.Text;
            shampoo.Brand = brand.Text;
          if(!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
               
                return;
            }
            shampoo.Price = newPrice;
           if( !double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            shampoo.Volume = newVolume;
           if(! int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            shampoo.QuantityBottles = newQuantity;
            shampoo.QuantityGeneralVolume = newQuantity * newVolume;
            shampoo.Description = description.Text;
            addFunction.AddShampooToDB(shampoo);
            price.BorderBrush = StandartBrush;
            volume.BorderBrush = StandartBrush;
            quantity.BorderBrush = StandartBrush;
        }
        private void AddBalsam()
        {
            Balsam balsam = new Balsam();
            balsam.Name = name.Text;
            balsam.Brand = brand.Text;
            if(!decimal.TryParse(price.Text, out decimal newPrice))
            {
                return;
            }
            balsam.Price = newPrice;
            if(!double.TryParse(volume.Text, out double newVolume))
            {
                return;
            }
            balsam.Volume = newVolume;
            if(!int.TryParse(quantity.Text, out int newQuantity))
            {
                return;
            }
            balsam.QuantityBottles = newQuantity;
            balsam.QuantityGeneralVolume = newQuantity * newVolume;
        }
        private void AddHairColor()
        {
            HairColor hairColor = new HairColor();
            hairColor.Name = name.Text;
            hairColor.Brand = brand.Text;
          if( ! decimal.TryParse(price.Text, out decimal newPrice))
            {
                return;
            }
            hairColor.Price = newPrice;
         if( !double.TryParse(volume.Text, out double newVolume))
            {
                return;
            }
            hairColor.Volume = newVolume;
            if(!int.TryParse(quantity.Text, out int newQuantity))
            {
                return;
            }
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
           if(! decimal.TryParse(price.Text, out decimal newPrice))
            {
                return;
            }
            laque.Price = newPrice;
         if(!double.TryParse(volume.Text, out double newVolume))
            {
                return;
            }
            laque.Volume = newVolume;
            if(!int.TryParse(quantity.Text, out int newQuantity))
            {
                return;
            }
            laque.QuantityBottles = newQuantity;
            laque.QuantityGeneralVolume = newQuantity * newVolume;

        }
        private void AddFoundation()
        {
            Foundation foundation = new Foundation();

            foundation.Name = name.Text;
            foundation.Brand = brand.Text;
            if(!decimal.TryParse(price.Text, out decimal newPrice))
            {
                return;
            }
            foundation.Price = newPrice;
           if( !double.TryParse(volume.Text, out double newVolume))
            {
                return;
            }
            foundation.Volume = newVolume;
           if( !int.TryParse(quantity.Text, out int newQuantity))
            {
                return;
            }
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
          if(!decimal.TryParse(price.Text, out decimal newPrice))
            {
                return;
            }
            powder.Price = newPrice;
           if(! double.TryParse(volume.Text, out double newVolume))
            {
                return;
            }
            powder.Volume = newVolume;
          if(!int.TryParse(quantity.Text, out int newQuantity))
            {
                return;
            }
            powder.QuantityBottles = newQuantity;
            powder.QuantityGeneralVolume = newQuantity * newVolume;
            powder.Color = color.Text;
        }
        private void AddShadow()
        {
            Shadows shadows = new Shadows();
            shadows.Name = name.Text;
            shadows.Brand = brand.Text;
            if(!decimal.TryParse(price.Text, out decimal newPrice))
            {
                return;
            }
            shadows.Price = newPrice;
            if(!double.TryParse(volume.Text, out double newVolume))
            {
                return;
            }
            shadows.Volume = newVolume;
           if( !int.TryParse(quantity.Text, out int newQuantity))
            {
                return;
            }
            shadows.QuantityBottles = newQuantity;
            shadows.QuantityGeneralVolume = newQuantity * newVolume;
            shadows.Color = color.Text;
        }
        private void AddMascara()
        {
            Mascara mascara = new Mascara();
            mascara.Name = name.Text;
            mascara.Brand = brand.Text;
            if(!decimal.TryParse(price.Text, out decimal newPrice))
            {
                return;
            }
            mascara.Price = newPrice;
          if(!double.TryParse(volume.Text, out double newVolume))
            {
                return;
            }
            mascara.Volume = newVolume;
            if(!int.TryParse(quantity.Text, out int newQuantity))
            {
                return;
            }
            mascara.QuantityBottles = newQuantity;
            mascara.QuantityGeneralVolume = newQuantity * newVolume;
            mascara.Color = color.Text;
        }
        private void AddLipstick()
        {
            Lipstick lipstick = new Lipstick();
            lipstick.Name = name.Text;
            lipstick.Brand = brand.Text;
           if(! decimal.TryParse(price.Text, out decimal newPrice))
            {
                return;
            }
            lipstick.Price = newPrice;
            if(!double.TryParse(volume.Text, out double newVolume))
            {
                return;
            }
            lipstick.Volume = newVolume;
           if( !int.TryParse(quantity.Text, out int newQuantity))
            {
                return;
            }
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
          if(!decimal.TryParse(price.Text, out decimal newPrice))
            {
                return;
            }
            top.Price = newPrice;
            if(!double.TryParse(volume.Text, out double newVolume))
            {
                return;
            }
            top.Volume = newVolume;
            if(!int.TryParse(quantity.Text, out int newQuantity))
            {
                return;
            }
            top.QuantityBottles = newQuantity;
            top.QuantityGeneralVolume = newQuantity * newVolume;

        }
        private void AddBase()
        {
            NailBase nailBase = new NailBase();
            nailBase.Name = name.Text;
            nailBase.Brand = brand.Text;
           if(! decimal.TryParse(price.Text, out decimal newPrice))
            {
                return;
            }
            nailBase.Price = newPrice;
            if(!double.TryParse(volume.Text, out double newVolume))
            {
                return;
            }
            nailBase.Volume = newVolume;
            if(!int.TryParse(quantity.Text, out int newQuantity))
            {
                return;
            }
            nailBase.QuantityBottles = newQuantity;
            nailBase.QuantityGeneralVolume = newQuantity * newVolume;
        }
        private void AddPolishNail()
        {
            NailPolish nailPolish = new NailPolish();
            nailPolish.Name = name.Text;
            nailPolish.Brand = brand.Text;
          if(!decimal.TryParse(price.Text, out decimal newPrice))
            {
                return;
            }
            nailPolish.Price = newPrice;
            if(!double.TryParse(volume.Text, out double newVolume))
            {
                return;
            }
            nailPolish.Volume = newVolume;
           if(!int.TryParse(quantity.Text, out int newQuantity))
            {
                return;
            }
            nailPolish.QuantityBottles = newQuantity;
            nailPolish.QuantityGeneralVolume = newQuantity * newVolume;
            nailPolish.Color = color.Text;
            addFunction.AddPolishToDB(nailPolish);
        }

        private void buyProduct(object sender, RoutedEventArgs e)
        {
            foreach (var item in StockRoom.Items)
            {
                if ((item as TabItem).IsSelected)
                {
                    if (((item as TabItem).Content as DataGrid).SelectedIndex>=0)
                    {
                        if (quantityToBuy.Value!=null)
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
