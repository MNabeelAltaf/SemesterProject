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
    /// Interaction logic for BusDetails.xaml
    /// </summary>
    public partial class BusDetails : Window
    {
        public BusDetails()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Close();
        }


        private int updatingDriverID = 0;
        private void ListBusDetail(object sender, SelectionChangedEventArgs e)
        {
            EditBusDetails bd = new EditBusDetails();
            bd.Show();

            if (this.BusDetails1.SelectedIndex >= 0)
            {
                if (this.BusDetails1.SelectedItems.Count >= 0)
                {
                    if (this.BusDetails1.SelectedItems[0].GetType() == typeof(Table4))
                    {
                        Table4 d = (Table4)this.BusDetails1.SelectedItems[0];


                        bd.depCitytxt.Text = d.Departure_City;
                        bd.DestCitytxt.Text = d.Destination_City;
                        bd.depTimingtxt.Text = d.Departure_Timing;
                        bd.engtxt.Text = d.Engine_Number;
                        bd.busClasstxt.Text = d.Bus_Class;

                        bd.busnumtxt.Text = d.Bus_No;
                        bd.seattxt.Text = d.Total_Seats.ToString();
                        bd.pricetxt.Text = d.Price.ToString();

                        this.updatingDriverID = d.Id;
                    }
                    
                }
            }


        }
        private void edit_btn(object sender, RoutedEventArgs e)
        {
            EditBusDetails bd = new EditBusDetails();
            bd.Show();
        }

        private void dlt_btn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Do you Want to Delete?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddNewBus newbus = new AddNewBus();
            newbus.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ProjectDBEntities1 db = new ProjectDBEntities1();
            BusDetails1.ItemsSource = db.Table4.ToList();
        }

            }
}
