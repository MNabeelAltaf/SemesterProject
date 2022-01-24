using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class historyTickets : Window
    {
        ProjectDBEntities1 db = new ProjectDBEntities1();
        public historyTickets()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(searchPhone.Text))
            {
                MessageBox.Show("Enter registered phone number", "Blank Field", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }

            if (!(searchPhone.Text.Length == 10))
            {
                MessageBox.Show("Phone number invalid", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                return;

            }
            else
            {
                try
                {
                    serchingPhoneNumber();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Ocured", "DataBase Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    Console.WriteLine("=======");
                    Console.WriteLine(ex);
                    Console.WriteLine("=======");

                }
            }
        }

        private void serchingPhoneNumber()
        {

            //var result = from database in db.Tables
            //             where database.Phone_Number.ToString() == searchPhone.Text
            //             select database;



            //Console.WriteLine(result);

            // ticketRecord.ItemsSource = result.ToList();


            ///

            var res = from t1 in db.Tables
                      join t2 in db.Table2
                      on t1.Id equals t2.Id
                      where t1.Phone_Number.ToString() == searchPhone.Text
                      select new
                      {
                          id = t1.Id,
                          FullName = t1.First_Name + " " + t1.Last_Name,
                          CNIC_No = t1.CNIC,
                          CurrentCity = t1.City,
                          PhoneNumber = t1.Phone_Number,
                          DepartureCity = t2.Departure_City,
                          DestinationCity = t2.Destination_City,
                          BusClass = t2.Bus_Class,
                          DepartureTiming = t2.Timing,

                      };

            ticketRecord.ItemsSource = res.ToList();



            ///

        }

        private void searchPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

        }

        private void searchPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            //x
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ScheduleWindow sw = new ScheduleWindow();
            sw.Show();
            this.Close();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //delete Row btn



            MessageBoxResult msgBoxResult = MessageBox.Show("Are you sure you want to Delete?",
            "Delete Records",
             MessageBoxButton.YesNo,
             MessageBoxImage.Warning,
             MessageBoxResult.No
             );


            if (msgBoxResult == MessageBoxResult.Yes)
            {

                var r1 = from d1 in db.Tables
                         where d1.Id == updatingid1
                         select d1;

                var r2 = from d2 in db.Table2
                         where d2.Id == updatingid2
                         select d2;

                Table tb1 = r1.SingleOrDefault();
                Table2 tb2 = r2.SingleOrDefault();

                if (tb1 != null && tb2 != null)
                {
                    db.Tables.Remove(tb1);
                    db.Table2.Remove(tb2);

                    db.SaveChanges();
                }





            }



        }

        private int updatingid1 = 0;
        private int updatingid2 = 0;
        private void ticketRecord_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ticketRecord.SelectedIndex >= 0)
            {
                if (ticketRecord.SelectedItems.Count >= 0)
                {
                    if (ticketRecord.SelectedItems[0].GetType() == typeof(Table)
                        && ticketRecord.SelectedItems[0].GetType() == typeof(Table2))
                    {
                        Table t1 = (Table)ticketRecord.SelectedItems[0];
                        Table2 t2 = (Table2)ticketRecord.SelectedItems[0];

                        updatingid1 = t1.Id;
                        updatingid2 = t2.Id;
                    }
                }
            }



        }
    }

}
