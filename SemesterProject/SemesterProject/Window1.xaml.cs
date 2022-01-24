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
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ProjectDBEntities1 db = new ProjectDBEntities1();




        public Window1()
        {
            InitializeComponent();

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // back button
            ScheduleWindow schedule = new ScheduleWindow();

            schedule.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ReservationProcess rp = new ReservationProcess();


            //validation method of user input


            rp.Show();
            this.Close();
        }

        private void NextBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            Next.Content = "Next";
        }

        private void NextBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            Next.Content = "";
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Back_lbl.Content = "Back";
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Back_lbl.Content = "";
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow schedule = new MainWindow();
            //schedule.Show();
            //this.Close();

        }

        private void Submit_btn_Click(object sender, RoutedEventArgs e)
        {


            if (string.IsNullOrEmpty(FName.Text))
            {
                MessageBox.Show("Enter First Name", "Blank Field Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(LName.Text))
            {
                MessageBox.Show("Enter Last Name", "Blank Field Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!(Male.IsChecked == true || Female.IsChecked == true))
            {
                MessageBox.Show("Select Gender", "Blank Field Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(Cnic.Text))
            {
                MessageBox.Show("Enter CNIC number (without spaces/dashes)", "Blank Field Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (!(Cnic.Text.Length == 13))
            {
                MessageBox.Show("CNIC number invalid", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (city.SelectedIndex == -1)
            {
                MessageBox.Show("Select City", "Blank Field Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(Ph.Text))
            {
                MessageBox.Show("Enter Phone Number", "Blank Field Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (!(Ph.Text.Length == 11))
            {
                MessageBox.Show("Phone number invalid", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(adress.Text))
            {
                MessageBox.Show("Enter Address", "Blank Field Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            else
            {

                MessageBoxResult option = MessageBox.Show("Are you sure to continue?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (option == MessageBoxResult.Yes)
                {

                    MessageBox.Show("Submitted Sucesfully", "Submitted", MessageBoxButton.OK, MessageBoxImage.Information);


                    NextBtn.IsEnabled = true;
                    NextImg.Opacity = 1;
                    Submit_btn.IsEnabled = false;

                    FName.IsEnabled = false;
                    LName.IsEnabled = false;
                    Male.IsEnabled = false;
                    Female.IsEnabled = false;
                    Cnic.IsEnabled = false;
                    city.IsEnabled = false;
                    Ph.IsEnabled = false;
                    adress.IsEnabled = false;
                    back.IsEnabled = false;
                    back.Opacity = 0.5;

                    try
                    {

                        Adding_RegistrationProcess();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occured", "Database Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        Console.WriteLine("=======");
                        Console.WriteLine(ex);
                        Console.WriteLine("=======");
                    }
                }

                else if (option == MessageBoxResult.No)
                {
                    MessageBox.Show("Action Cancelled", "Cancelled", MessageBoxButton.OK, MessageBoxImage.Information);

                }


            }


        }

        string gender;
        private void Adding_RegistrationProcess()
        {
            // adding registration process data to Database (Table)



            if (Male.IsChecked == true)
            {
                gender = "Male";
            }
            else if (Female.IsChecked == true)
            {
                gender = "Female";
            }

            Table t = new Table()
            {
                First_Name = FName.Text,
                Last_Name = LName.Text,
                Gender = gender,
                CNIC = Convert.ToInt64(Cnic.Text),
                City = city.Text,
                Phone_Number = Convert.ToInt64(Ph.Text),
                Address = adress.Text,

            };

            db.Tables.Add(t);
            db.SaveChanges();



            MessageBox.Show("Data Stored Sucessfully!", "Data Saved", MessageBoxButton.OK, MessageBoxImage.Information);



        }

        private void Submit_btn_MouseLeave(object sender, MouseEventArgs e)
        {
            Submit_btn.Background = Brushes.Silver;
        }

        private void Ph_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
