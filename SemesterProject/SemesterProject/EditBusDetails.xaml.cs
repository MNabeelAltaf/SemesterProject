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
    /// Interaction logic for EditBusDetails.xaml
    /// </summary>
    public partial class EditBusDetails : Window
    {
        public EditBusDetails()
        {
            InitializeComponent();
        }
        private int updatingBusID = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProjectDBEntities1 db = new ProjectDBEntities1();

            var r = from d in db.Table4
                    where d.Id == this.updatingBusID
                    select d;

            Table4 obj = r.SingleOrDefault();

            if (obj != null)
            {
                this.depCitytxt.Text = obj.Departure_City;
                this.DestCitytxt.Text =obj.Destination_City;
                this.depTimingtxt.Text = obj.Departure_Timing;
                this.engtxt.Text = obj.Engine_Number;
                this.busClasstxt.Text = obj.Bus_Class;

                this.busnumtxt.Text = obj.Bus_No;
                this.seattxt.Text = obj.Total_Seats.ToString();
                this.pricetxt.Text = obj.Price.ToString();

                db.SaveChanges();
            }

        }
    }
}
