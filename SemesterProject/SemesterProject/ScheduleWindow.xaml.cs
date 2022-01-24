using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for ScheduleWindow.xaml
    /// </summary>
    public partial class ScheduleWindow : Window
    {
        public ScheduleWindow()
        {
            InitializeComponent();
        }
        void schedule()
        {
            DataTable dt = new DataTable();


            DataColumn From = new DataColumn("From", typeof(string));
            DataColumn To = new DataColumn("To", typeof(string));
            DataColumn BusClass = new DataColumn("Bus Class", typeof(string));
            DataColumn Timming = new DataColumn("Departure Timing", typeof(string));
            DataColumn Price = new DataColumn("Price per seat", typeof(int));

            dt.Columns.Add(From);
            dt.Columns.Add(To);
            dt.Columns.Add(BusClass);
            dt.Columns.Add(Timming);
            dt.Columns.Add(Price);

            DataRow firstRow = dt.NewRow();
            firstRow[0] = "Islamabad";
            firstRow[1] = "Lahore";
            firstRow[2] = "Economy Class";
            firstRow[3] = "8:30 a.m";
            firstRow[4] = "1200";

            DataRow secondRow = dt.NewRow();
            secondRow[0] = "Islamabad";
            secondRow[1] = "Lahore";
            secondRow[2] = "Business Class";
            secondRow[3] = "11:30 a.m";
            secondRow[4] = "2000";

            DataRow thirdRow = dt.NewRow();
            thirdRow[0] = "Islamabad";
            thirdRow[1] = "Lahore";
            thirdRow[2] = "First Class";
            thirdRow[3] = "2:00 p.m";
            thirdRow[4] = "3000";


            DataRow forthRow = dt.NewRow();
            forthRow[0] = "Lahore";
            forthRow[1] = "Islamabad";
            forthRow[2] = "Economy Class";
            forthRow[3] = "8:30 a.m";
            forthRow[4] = "1200";

            DataRow fifthRow = dt.NewRow();
            fifthRow[0] = "Lahore";
            fifthRow[1] = "Islamabad";
            fifthRow[2] = "Business Class";
            fifthRow[3] = "11:30 a.m";
            fifthRow[4] = "2000";

            DataRow sixthRow = dt.NewRow();
            sixthRow[0] = "Lahore";
            sixthRow[1] = "Islamabad";
            sixthRow[2] = "First Class";
            sixthRow[3] = "2:00 p.m";
            sixthRow[4] = "3000";

            dt.Rows.Add(firstRow);
            dt.Rows.Add(secondRow);
            dt.Rows.Add(thirdRow);
            dt.Rows.Add(forthRow);
            dt.Rows.Add(fifthRow);
            dt.Rows.Add(sixthRow);

            Schedule.ItemsSource = dt.DefaultView;


        }

        private void Schedule_Loaded(object sender, RoutedEventArgs e)
        {
            this.schedule();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 register = new Window1();
            register.Show();
            this.Close();

        }

        private void Schedule_MouseEnter(object sender, MouseEventArgs e)
        {
            Schedule.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            historyTickets ht = new historyTickets();
            ht.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AdminLoginScreen ad = new AdminLoginScreen();
            ad.Show();
            this.Close();
        }
    }
}
