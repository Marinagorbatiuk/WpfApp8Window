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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dal;
namespace WpfApp8Window
{
    /// <summary>
    /// Interaction logic for Actions.xaml
    /// </summary>
    public partial class Actions : UserControl
    {
        GetFunction getFunction = new GetFunction();

        public Actions()
        {
            InitializeComponent();
        }

        private void load(object sender, RoutedEventArgs e)
        {
            operations.ItemsSource = getFunction.GetLoggs();

        }
    }
}
