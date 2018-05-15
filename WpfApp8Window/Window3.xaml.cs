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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
namespace WpfApp8Window
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : MetroWindow
    {
        UserControlOrder order = new UserControlOrder();
        public Window3()
        {
            InitializeComponent();
        }

        private void ListViewMenu_SelectionChangedUser(object sender, SelectionChangedEventArgs e)
        {
            if (logoutUser.IsSelected)
            {
                if (order.ok.IsPressed == false)
                {
                    Dialog.IsOpen = true;
                    if (yesButton.IsPressed)
                    {
                        yes(null, null);
                    }
                    else if (noButton.IsPressed)
                    {
                        no(null, null);
                    }
                }
            }

           else if (Order.IsSelected)
            {
                UserControlOrder order = new UserControlOrder();
                ControlUser.Content = order;
                Order.IsEnabled = false;
            }
        }

        private void MenuUser(object sender, RoutedEventArgs e)
        {
            splitUser.IsPaneOpen = !splitUser.IsPaneOpen;
        }

        private void no(object sender, RoutedEventArgs e)
        {
            Dialog.IsOpen = false;
            logoutUser.IsSelected = false;
        }

        private void yes(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
