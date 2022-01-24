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
    /// Interaction logic for DriverDetails.xaml
    /// </summary>
    public partial class DriverDetails : Window
    {
        ProjectDBEntities1 db = new ProjectDBEntities1();
        public DriverDetails()
        {
            InitializeComponent();

        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddNewDriver newdriver = new AddNewDriver();
            newdriver.Show();
        }

        private int updatingBusID = 0;
        private void ListDriverDetails(object sender, SelectionChangedEventArgs e)
        {
            AddNewDriver newdriver = new AddNewDriver();
            newdriver.Show();

            if (this.DriverDetail.SelectedIndex >= 0)
            {
                if (this.DriverDetail.SelectedItems.Count >= 0)
                {
                    if (this.DriverDetail.SelectedItems[0].GetType() == typeof(Table3))
                    {
                        Table3 d = (Table3)this.DriverDetail.SelectedItems[0];

                        newdriver.nametxt.Text = d.Name.ToString();
                        newdriver.licencetxt.Text = d.Licence_.ToString();
                        newdriver.Addresstxt_.Text = d.Address.ToString();
                        newdriver.Contacttxt.Text = d.contact.ToString();
                        newdriver.CNICtxt.Text = d.Cnic.ToString();

                        this.updatingBusID = d.Id;
                    }
                }
            }


        }
        

        private void DriverDelBtn(object sender, RoutedEventArgs e)
        {
            {
                MessageBoxResult msgBoxResult = MessageBox.Show("Are you sure you want to Delete?",
                    "Delete Doctor",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning,
                    MessageBoxResult.No
                    );

                if (msgBoxResult == MessageBoxResult.Yes)
                {

                    ProjectDBEntities1 db = new ProjectDBEntities1();

                    var r = from d in db.Table3
                            where d.Id == this.updatingBusID
                            select d;

                    Table3 obj = r.SingleOrDefault();

                    if (obj != null)
                    {
                        db.Table3.Remove(obj);
                        db.SaveChanges();
                    }
                }

            }
        }
       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ProjectDBEntities1 db = new ProjectDBEntities1();
            DriverDetail.ItemsSource = db.Table3.ToList();
        }

        
    }
}
