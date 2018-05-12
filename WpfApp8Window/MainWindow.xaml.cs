using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Dal;
using System.Windows.Media.Animation;


namespace WpfApp8Window
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        GetFunction function = new GetFunction();
        Brush StandartBrush = null;
        public MainWindow()
        {
            InitializeComponent();
            ring.Visibility = Visibility.Hidden;
            StandartBrush = log.BorderBrush;
        }

        private async void ok(object sender, RoutedEventArgs e)
        {
            string password = pass.Password;
            string login = log.Text;
            ring.Visibility = Visibility.Visible;
            (sender as Button).IsEnabled = false;
            Staff Staff = await Task.Run(() =>
           {
               Staff GetStaff = function.GetUserAutorization(login, password);
               return GetStaff;
           });
          
            if (Staff != null)
            {
                if (Staff.WorkPosition.Name == "Admin")
                {
                    Window2 window = new Window2();
                    App.Current.MainWindow = window;
                    this.Close();
                    window.Show();
                }
                else if (Staff.WorkPosition.Name == "Employee")
                {
                    Window3 window = new Window3();
                    App.Current.MainWindow = window;
                    this.Close();
                    window.Show();
                }
            }
            else
            {
                IncorectAutorization(sender);
            }
            ring.Visibility = Visibility.Hidden;         
        }
        private async void IncorectAutorization(object sender)
        {
            pass.BorderBrush = Brushes.Red;
            log.BorderBrush = Brushes.Red;

            await Task.Run(() =>
            { Thread.Sleep(1000); });

            log.BorderBrush = StandartBrush;
            pass.BorderBrush = StandartBrush;
            (sender as Button).IsEnabled = true;
        }
    }
}
