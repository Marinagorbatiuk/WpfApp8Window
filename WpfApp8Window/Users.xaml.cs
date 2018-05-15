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
    /// Interaction logic for Users.xaml
    /// </summary>
    public partial class Users : UserControl
    {
        GetFunction getFunction = new GetFunction();
        AddFunction addFunction = new AddFunction();
        DeleteFunction deleteFunctionn = new DeleteFunction();
        List<WorkPosition> positions = new List<WorkPosition>();
        
        public Users()
        {
            InitializeComponent();
            positions = getFunction.GetListPositions();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            Staff newstaff = new Staff();
            newstaff.Login = login.Text;
            newstaff.Password = pass.Text;
            //foreach( var item in positions)
            //{
            //  //MessageBox.Show(item.Id.ToString() + item.Name);
            //}
            if(adminRadioButton.IsChecked==true)
            {
                //if (newstaff.Login==)
                newstaff.WorkPosition = positions.First(x => x.Name == "Admin");
                addFunction.AddEmployee(newstaff);
                load(null, null);
            }
            if(employeeRadioButton.IsChecked == true)
            {
                newstaff.WorkPosition = positions.First(x => x.Name == "Employee");
                addFunction.AddEmployee(newstaff);
                load(null, null);
            }        
        }
        private void del_Click(object sender, RoutedEventArgs e)
        { 
                deleteFunctionn.DeleteEmployee((GridUser.SelectedItem as Staff).Id);
                load(null, null);
        }
        private void load(object sender, RoutedEventArgs e)
        {
            GridUser.ItemsSource = null;
           GridUser.ItemsSource = getFunction.GetEmployees();
        }
    }
}
