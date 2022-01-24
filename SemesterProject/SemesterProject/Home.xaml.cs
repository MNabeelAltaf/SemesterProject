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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void agreeChkBox_Checked(object sender, RoutedEventArgs e)
        {
            if ((agreeChkBox.IsChecked == true))
            {
                nextBtn.IsEnabled = true;
                agreeChkBox.IsEnabled = false;

            }




        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            ScheduleWindow sw = new ScheduleWindow();
            sw.Show();
            this.Close();
        }
    }
}
