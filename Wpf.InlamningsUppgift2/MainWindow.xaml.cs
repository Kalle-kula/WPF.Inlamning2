using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf.InlamningsUppgift2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string customerType;
        private string newsLetter;
        string path = @"C:\Users\Kalle\Desktop\c#.txt";



        //private ObservableCollection<Applicant> applicants; 
        public MainWindow()
        {
            InitializeComponent();
            //applicants = new ObservableCollection<Applicant>();
            //DataContext = applicants;
            //Applicant applicant = employeeContext.Applicants.Single(x => x.ApplicantId == id);
            ApplicantContext applicantContext = new ApplicantContext();

            //var TextBox = new TextBox();
            //för att lägga in en textbox med färger (som blir grå när privat är vald) 

        }

        private void RadioBtnPriv_OnChecked(object sender, RoutedEventArgs e)
        {
            TxtBoxComp.IsReadOnly = true;
            TxtBoxComp.Text = "Privatkund";
            customerType = "Privatkund";
        }

        private void RadioBtnComp_OnChecked(object sender, RoutedEventArgs e)
        {
            TxtBoxComp.IsReadOnly = false;
            TxtBoxComp.Text = string.Empty;
            customerType = "Företagskund";
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {

            //for (int i = 0; i < 1000; i++)
            //{

            //}
            //if (TxtBoxComp.Text == )
            //{
                
            //}
            string company = TxtBoxComp.Text;
            string name = TxtContactFirst.Text + " " + TxtContactSur.Text;
            string birthDate = DatePicker.SelectedDate.Value.ToShortDateString();
            string adress = TxtAddressStreet.Text + " " + TxtAddressZip.Text + " " + TxtAddressCity.Text;
            string phone = TxtPhone.Text;
            string eMail = TxtEmail.Text;
            string notes = TxtRichNote.Text;
            int counter = 1;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }
            file.Close();
            StreamWriter sw = new StreamWriter(path, true);

            sw.WriteLine(counter + ";" + customerType + ";" + company + ";" + name + ";" + birthDate + ";" + adress + ";" + phone + ";" + eMail + 
                ";" + newsLetter + ";" + notes + ";");
            sw.Close();
            MessageBox.Show("Sparat!");

        }

        private void CheckBoxYes_OnChecked(object sender, RoutedEventArgs e)
        {
            newsLetter = "Vill ha nyhetsbrev";
        }

        private void BtnSearch_OnClick(object sender, RoutedEventArgs e)
        {

            //foreach (var match in File.ReadLines(path)
            //              .Select((text, index) => new { text, lineNumber = index + 1 })
            //              .Where(x => x.text.Contains("SEARCHWORD")))
            //{
            //    TxtRichSearch.Text = (match.lineNumber + match.text);
            //}

            string line;

            StreamReader file = new StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                //foreach (var lin in line)
                //{
                    if (line.Contains(TxtBoxSearch.Text))
                    {
                    
                      line = line.Replace(";", " ");
                    TxtRichSearch.Text += line;
                        
                    }

                //}
            }
            file.Close();
        }
    }
}
