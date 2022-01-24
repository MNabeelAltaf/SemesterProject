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
    /// Interaction logic for ReservationProcess.xaml
    /// </summary>
    
   public partial class ReservationProcess : Window
        {
            ProjectDBEntities1 db = new ProjectDBEntities1();
            public ReservationProcess()
            {
                InitializeComponent();

            }

            private void paymentField_MouseEnter(object sender, MouseEventArgs e)
            {




            }

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                /* validating all enteries then brcomes inactive and saves data to file
                 and displays Ticket to user.
                 */
            }

            private void Button_MouseLeave(object sender, MouseEventArgs e)
            {

            }

            private void Submit_Click(object sender, RoutedEventArgs e)
            {

                if (source1.SelectedIndex == -1)
                {
                    MessageBox.Show("Select City (From)", "Blank Field Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (destination1.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Destination City (To)", "Blank Field Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (!(Bus_class.SelectedIndex > -1))
                {
                    MessageBox.Show("Select Bus Class", "Blank Field Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (!(timing.SelectedIndex > -1))
                {
                    MessageBox.Show("Select timings", "Blank Field Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (!(JazzCash.IsChecked == true || EasyPaisa.IsChecked == true))
                {
                    MessageBox.Show("Select payment option", "Blank Field Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (string.IsNullOrEmpty(AccountNumber.Text))
                {
                    MessageBox.Show("Enter account number", "Blank Field Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {

                    MessageBoxResult Useroption = MessageBox.Show("Are you sure to Continue", "Question", MessageBoxButton.OKCancel, MessageBoxImage.Question);

                    if (Useroption == MessageBoxResult.OK)
                    {
                        MessageBox.Show("Submit Sucessfully!", "Submitted", MessageBoxButton.OK, MessageBoxImage.Asterisk);

                        source1.IsEnabled = false;
                        destination1.IsEnabled = false;
                        EasyPaisa.IsEnabled = false;
                        JazzCash.IsEnabled = false;
                        AccountNumber.IsEnabled = false;
                        undo.IsEnabled = false;
                        Submit.IsEnabled = false;

                        try
                        {
                            adding_reservationProcess();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Database Error Occured", "DB Error!", MessageBoxButton.OK, MessageBoxImage.Error);

                            Console.WriteLine("========");
                            Console.WriteLine(ex);
                            Console.WriteLine("========");

                        }

                    }

                    if (Useroption == MessageBoxResult.Cancel)
                    {
                        MessageBox.Show("Action Cancelled!", "", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    }

                    if (Useroption == MessageBoxResult.OK)
                    {
                        // apply background worker then move to  next screen (Ticket)
                        Ticket t = new Ticket();
                        t.Show();
                        this.Close();
                    }

                }
            }

            private void adding_reservationProcess()
            {
                //adding reservation process data to Database (Table2)

                Table2 t2 = new Table2()
                {
                    Departure_City = source1.Text,
                    Destination_City = destination1.Text,
                    Bus_Class = Bus_class.Text,
                    Timing = timing.Text,
                    Account_Number = Convert.ToInt64(AccountNumber.Text),

                };

                db.Table2.Add(t2);
                db.SaveChanges();

            }

            private void EasyPaisa_Checked(object sender, RoutedEventArgs e)
            {
                if (EasyPaisa.IsChecked == true)
                {
                    AccountNumber.Text = "";
                    AccountNumber.IsEnabled = true;
                }
            }

            private void JazzCash_Checked(object sender, RoutedEventArgs e)
            {
                if (JazzCash.IsChecked == true)
                {
                    AccountNumber.Text = "";
                    AccountNumber.IsEnabled = true;
                }
            }

            private void source1_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

                if (source1.SelectedIndex > -1)
                {
                    destination1.Items.RemoveAt(source1.SelectedIndex);
                    source1.IsEnabled = false;

                    destination1.IsEnabled = true;


                }

            }

            private void Button_Click_1(object sender, RoutedEventArgs e)
            {


                source1.Text = "";
                destination1.Text = "";

                source1.IsEnabled = true;
                source1.IsEnabled = true;

                destination1.Items.Clear();

                destination1.Items.Add("Lahore");
                destination1.Items.Add("Rawalpindi");
                destination1.Items.Add("Multan");

                source1.Items.Clear();

                source1.Items.Add("Lahore");
                source1.Items.Add("Rawalpindi");
                source1.Items.Add("Multan");


            }



            private void destination1_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                //if ( !(source1.SelectedIndex > -1) ) 
                //{
                //   // source1.Items.RemoveAt(destination1.SelectedIndex);
                //    MessageBox.Show("Please Select City (From) first");

                //    return;

                //}
                //else
                //{
                destination1.IsEnabled = false;
                // }
            }

            private void AccountNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
            {
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.Text);
            }
        }
    }


