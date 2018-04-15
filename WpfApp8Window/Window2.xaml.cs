﻿using System;
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
using System.Windows.Shapes;
using BLL;
using MahApps.Metro.Controls;
namespace WpfApp8Window
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : MetroWindow
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void ok(object sender, RoutedEventArgs e)
        {
            split.IsPaneOpen = !split.IsPaneOpen;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (logout.IsSelected)
            {
                MainWindow main = new MainWindow();
                App.Current.MainWindow = main;
                this.Close();
                main.Show();
            }
            if (materials.IsSelected)
            { UserControlMaterials materials = new UserControlMaterials();
                control.Content = materials;

                //BusinessLogic bll = new BusinessLogic();
                //bll.GetListShampoo();
                //materials.GridShampoo.ItemsSource= 
            }
        }
    }
}