using System;
using System.Collections.Generic;
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

namespace MoneySaver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double max;
        private DateTime tijd;
        private DateTime tijdnu;
        private int weeks;
        private double add;
        private double tesparen;

        public MainWindow()
        {
            InitializeComponent();
            tijdnu = DateTime.Now;


            //locatie van savefile
            string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            destination = System.IO.Path.Combine(destination, "spaar.txt");

            //als bestand niet bestaat
            if (!File.Exists(destination))
            {
                max = 1;
                add = 0;
                p1.Maximum = max;
                tijd = DateTime.Now;
                weeks = 0;
                tesparen = 0;
                aantalweken.Content = tesparen + " € te sparen elke week";
                p1.Value = add;
                percentage.Content = (add / max) * 100 + " %";
                maximumbedrag.Text = "";
                nieuwebedrag.Text = "";
            }
            else
            {
                //lees een save file begin
                //construeer een pad




                //open een conecite naar het bestand
                StreamReader inputStream = File.OpenText(destination);
                //lees alle data
                string maxline = inputStream.ReadLine();
                string tijdline = inputStream.ReadLine();
                string weeksline = inputStream.ReadLine();
                string addline = inputStream.ReadLine();
                string tesparenline = inputStream.ReadLine();

                inputStream.Close();
              //  MessageBox.Show(tijdline + "");
                max = Convert.ToInt32(maxline);
                tijd = Convert.ToDateTime(tijdline);
                weeks = Convert.ToInt32(weeksline);
                add = Convert.ToDouble(addline);
                tesparen = Convert.ToDouble(tesparenline);

                p1.Maximum = max;
                aantalweken.Content = tesparen + " € te sparen elke week";
                p1.Value = add;
                percentage.Content = Math.Round((add / max) * 100, 2) + " %";
                maximumbedrag.Text = Convert.ToString(max);
                nieuwebedrag.Text = Convert.ToString(add);
                kalender.SelectedDate = tijd;
                kalender.DisplayDate = tijd;
            }


        }

        private void calculate(object sender, RoutedEventArgs e)
        {
            //schrijf een save file begin
            //construeer een pad
            string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
          

            destination = System.IO.Path.Combine(destination, "spaar.txt");
           
            max = Convert.ToDouble(maximumbedrag.Text);
            add = Convert.ToDouble(nieuwebedrag.Text);
          //  MessageBox.Show(tijd + "");
          //  kalender.DisplayDate = tijd;
           
            


            p1.Maximum = max;
          
           tijd = Convert.ToDateTime(kalender.SelectedDate);
            //kalender.SelectedDate = tijd;
            //MessageBox.Show(tijd + "");
            weeks = Convert.ToInt32((tijd - tijdnu).TotalDays / 7);
            tesparen = (max - add) / weeks;
            tesparen = Math.Round(tesparen, 2);
            aantalweken.Content = tesparen + " € te sparen elke week";

            p1.Value = add;
            percentage.Content = Math.Round((add / max) * 100, 2)+" %";
          //  percentage.Content = (add / max) * 100 + " %";
            // maak connecite met een bestand
            StreamWriter outputStream = File.CreateText(destination);
            outputStream.WriteLine(max);
            outputStream.WriteLine(tijd);
            outputStream.WriteLine(weeks);
            outputStream.WriteLine(add);
            outputStream.WriteLine(tesparen);
            
            outputStream.Close();



           





        }
    }
    }

