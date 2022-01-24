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

namespace SemesterProject
{
    /// <summary>
    /// Interaction logic for AdminLoginScreen.xaml
    /// </summary>
    public partial class AdminLoginScreen : Window
    {
        public AdminLoginScreen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(userName.Text == "admin" && passBox.Password=="admin") 
            {
                AdminDashboard admin = new AdminDashboard();
                admin.Show();
                this.Close();
            }
            
            else if(userName.Text == "Nabeel" && passBox.Password == "123")
            {
                AdminDashboard admin = new AdminDashboard();
                admin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid UserName/Password");
            }
        }
    }
}
