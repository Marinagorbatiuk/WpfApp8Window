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
            {
                UserControlMaterials materials = new UserControlMaterials();
                control.Content = materials;
            }
            if (users.IsSelected)
            {
                Users user = new Users();
                control.Content = user;
            }
            if(statistics.IsSelected)
            {
                Statistics statisticsControl = new Statistics();
                control.Content = statisticsControl;
            }
            if ( actions.IsSelected)
            {
                Actions actionControl = new Actions();
                control.Content = actionControl;
            }
        }
    }
}
