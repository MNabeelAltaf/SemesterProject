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
    /// Interaction logic for AddNewBus.xaml
    /// </summary>
    public partial class AddNewBus : Window
    {
        public AddNewBus()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                ProjectDBEntities1 db = new ProjectDBEntities1();

            Table4 busObject = new Table4()
            {
                Departure_City = depCitytxt.Text,
                Destination_City = DestCitytxt.Text,
                Departure_Timing = depTimingtxt.Text,
                Engine_Number = engtxt.Text,
                Bus_Class = busClasstxt.Text,
                Bus_No = busnumtxt.Text,
                Total_Seats = int.Parse(seattxt.Text),
                Price = (int)Convert.ToInt64(pricetxt.Text),


            };
            db.Table4.Add(busObject);
            db.SaveChanges();

        }


    }
    }

