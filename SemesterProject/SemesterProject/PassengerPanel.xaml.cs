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
   
    public partial class PassengerPanel : Window
    {
        public PassengerPanel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserRecord ur = new UserRecord();
            ur.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SeatsAvailability sa = new SeatsAvailability();
            sa.Show();
      

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Close();
        }
    }
}
