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
    /// Interaction logic for AddNewDriver.xaml
    /// </summary>
    public partial class AddNewDriver : Window
    {
       
        public AddNewDriver()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProjectDBEntities1 db = new ProjectDBEntities1();
            Table3 driverobj = new Table3()
            {
                Name = nametxt.Text,
                Cnic = (int)Convert.ToInt64(CNICtxt.Text),
                Licence_ = (int)Convert.ToInt64(licencetxt.Text),
                contact = (int)Convert.ToInt64(Contacttxt.Text),
                Address = Addresstxt_.Text,
            
            };

            MessageBox.Show("SuccessFull");
            db.Table3.Add(driverobj);
            db.SaveChanges();

        }


        private int updatingDriverID = 0;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProjectDBEntities1 db = new ProjectDBEntities1();

            var r = from d in db.Table3
                    where d.Id == this.updatingDriverID
                    select d;

            Table3 obj = r.SingleOrDefault();

            if (obj != null)
            {
                obj.Name = this.nametxt.Text;
                obj.Cnic = (int)Convert.ToInt64(this.CNICtxt.Text);
                obj.contact = (int)Convert.ToInt64(this.Contacttxt.Text);
                obj.Licence_ = (int)Convert.ToInt64(this.licencetxt.Text);
                obj.Address = this.Addresstxt_.Text;

                db.SaveChanges();
            }
        }
    }
}
