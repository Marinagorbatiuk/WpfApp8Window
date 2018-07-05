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
                        AddMaterial(new Shampoo());
                    }
                   else if ((item as TabItem).Header.ToString() == "Balsam")
                    {
                        AddMaterial(new Balsam());
                    }
                        
                  else  if ((item as TabItem).Header.ToString() == "Color")
                    {
                        HairColor hairColor = new HairColor
                        {
                          Color = color.Text,
                          Description=description.Text
                        };
                        AddMaterial(hairColor);
                    }
                       
                   else if ((item as TabItem).Header.ToString() == "Laque")
                    {
                        AddMaterial(new Laque());
                    }
                        
                  else if ((item as TabItem).Header.ToString() == "Powder")
                    {
                        Powder powder = new Powder
                        {
                            Color=color.Text
                        };
                        AddMaterial(powder);
                    }
                        
                  else  if ((item as TabItem).Header.ToString() == "Foundation")
                    {
                        Foundation foundation = new Foundation
                        {
                            Color = color.Text,
                            Description = description.Text
                        };
                        AddMaterial(foundation);
                    }
                        
                  else  if ((item as TabItem).Header.ToString() == "Shadow")
                    {
                        Shadows shadows = new Shadows
                        {
                            Color = color.Text
                        };
                        AddMaterial(shadows);
                    }
                        
                   else if ((item as TabItem).Header.ToString() == "Lipstick")
                    {
                        Lipstick lipstick = new Lipstick
                        {
                            Color = color.Text,
                            Description = description.Text
                        };
                        AddMaterial(lipstick);
                    }
                      
                  else  if ((item as TabItem).Header.ToString() == "Mascara")
                    {
                        Mascara mascara = new Mascara
                        {
                            Color = color.Text,
                        };
                        AddMaterial(mascara);
                    }
                        
                   else if ((item as TabItem).Header.ToString() == "NailBase")
                    {
                       
                        AddMaterial(new NailBase());
                    }
                        
                   else if ((item as TabItem).Header.ToString() == "NailTop")
                    {
                        AddMaterial(new NailTop());
                    }
                       
                   else if ((item as TabItem).Header.ToString() == "NailEnamel")
                    {
                        NailPolish nailPolish = new NailPolish
                        {
                            Color = color.Text,
                        };
                        AddMaterial(nailPolish); 
                    }
                        
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
        private void AddMaterial(Material material)
        {
           // Material material = new Material();
            material.Name = name.Text;
            material.Brand = brand.Text;
            if (!decimal.TryParse(price.Text, out decimal newPrice))
            {
                price.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                price.BorderBrush = StandartBrush;
            }
            material.Price = newPrice;
            if (!double.TryParse(volume.Text, out double newVolume))
            {
                volume.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                volume.BorderBrush = StandartBrush;
            }
            material.Volume = newVolume;
            if (!int.TryParse(quantity.Text, out int newQuantity))
            {
                quantity.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                quantity.BorderBrush = StandartBrush;
            }
            material.QuantityBottles = newQuantity;
            material.QuantityGeneralVolume = newQuantity * newVolume;
        
            addFunction.AddMaterialsToDB(material);
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
                            Material materials = ((item as TabItem).Content as DataGrid).SelectedItem as Material;
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
                    deleteFunction.DeleteProduct((((item as TabItem).Content as DataGrid).SelectedItem as Material).Id);
                    load(null, null);
                }
            }
        }
        private void load(object sender, RoutedEventArgs e)
        {
            var Materials = getFunction.GetMaterials(); 

            GridShampoo.ItemsSource = null;
            GridShampoo.ItemsSource = Materials.Where(x=> x is Shampoo);
            GridBalsam.ItemsSource = null;
            GridBalsam.ItemsSource = Materials.Where(x => x is Balsam);
            GridColor.ItemsSource = null;
            GridColor.ItemsSource = Materials.Where(x => x is HairColor);
            GridFoundation.ItemsSource = null;
            GridFoundation.ItemsSource = Materials.Where(x => x is Foundation);
            GridLaque.ItemsSource = null;
            GridLaque.ItemsSource = Materials.Where(x => x is Laque);
            GridLipstick.ItemsSource = null;
            GridLipstick.ItemsSource = Materials.Where(x => x is Lipstick);
            GridMascara.ItemsSource = null;
            GridMascara.ItemsSource = Materials.Where(x => x is Mascara);
            GridBase.ItemsSource = null;
            GridBase.ItemsSource = Materials.Where(x => x is NailBase);
            GridNailEnamel.ItemsSource = null;
            GridNailEnamel.ItemsSource = Materials.Where(x => x is NailPolish);
            GridNailTop.ItemsSource = null;
            GridNailTop.ItemsSource = Materials.Where(x => x is NailTop);
            GridPowder.ItemsSource = null;
            GridPowder.ItemsSource = Materials.Where(x => x is Powder);
            GridShadow.ItemsSource = null;
            GridShadow.ItemsSource = Materials.Where(x => x is Shadows);
            quantityToBuy.Value = 1;
        }

        private void ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            (sender as NumericUpDown).Value = (int)(sender as NumericUpDown).Value;
        }
    }
}
