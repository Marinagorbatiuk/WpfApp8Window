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
using MahApps.Metro.Controls;
using BLL;
using System.Windows.Media.Animation;

namespace WpfApp8Window
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void ok(object sender, RoutedEventArgs e)
        {
            // BllWorkPosition position= LoginMethod(log.Text, pass.Password);
            //BusinessLogic bll = new BusinessLogic();
            //BllWorkPosition bllWork = new BllWorkPosition();
            // Task<List<BllWorkPosition>> listPositions = GetWorkerJobPosition();
            //listPositions.Start();
            //  MessageBox.Show("Pre wait");
            // listPositions.Wait();
            //   MessageBox.Show("Post wait");

            string password = pass.Password;
            string login = log.Text;


            //progbar.IsIndeterminate = false;          
            //Duration duration = new Duration(TimeSpan.FromSeconds(8));
            //DoubleAnimation doubleanimation = new DoubleAnimation(100.0, duration);
            //progbar.BeginAnimation(ProgressBar.ValueProperty, doubleanimation);

            ring.Visibility = Visibility.Visible;
            BllWorkPosition position =  await Task.Run(() =>
            {
                BusinessLogic bll = new BusinessLogic();
                BllWorkPosition bllWork = new BllWorkPosition();
                //ring.Visibility = Visibility.Visible;

                bllWork = bll.BllGetUser(login, password);
                return bllWork;
            } );

            List<BllWorkPosition> listPositions = await Task.Run(() =>
            {
                //ring.Visibility = Visibility.Visible;
                BusinessLogic bll = new BusinessLogic();
                List<BllWorkPosition> positions = bll.GetListPositions();
                return positions;
            });

            if (position.Name == listPositions.Where(x => x.Name == "Admin").Single().Name)
            {
                //ring.Visibility = Visibility.Visible;
                Window2 window = new Window2();
                App.Current.MainWindow = window;
                this.Close();
                window.Show();
            }
            else if (position.Name == listPositions.Where(x => x.Name == "Employee").Single().Name)
            {
                //ring.Visibility = Visibility.Visible;
                Window3 window = new Window3();
                App.Current.MainWindow = window;
                this.Close();
                window.Show();
            }
            else
            {
                //ring.Visibility = Visibility.Visible;
                MessageBox.Show("Test");
            }


        }

     // private  BllWorkPosition LoginMethod(string login, string password)
     // {
     //     BusinessLogic bll = new BusinessLogic();
     //     BllWorkPosition bllWork = new BllWorkPosition();
     //     bllWork= bll.BllGetUser(login, password);
     //     return bllWork;
     // }
     //
     // private async Task<List<BllWorkPosition>> GetWorkerJobPosition()
     // {
     //     BusinessLogic bll = new BusinessLogic();
     //     List<BllWorkPosition> positions = bll.GetListPositions();
     //     return positions;
     // }

    }
}
