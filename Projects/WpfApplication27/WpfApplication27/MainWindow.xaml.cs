using Microsoft.Win32;
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

namespace WpfApplication27
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void writefile(object sender, RoutedEventArgs e)
        {

            //construeer een pad
            string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            destination = System.IO.Path.Combine(destination, "myfile.txt");
          

            // maak connecite met een bestand
            StreamWriter outputStream = File.CreateText(destination);
            //schrijf data weg naar het bestna
            outputStream.WriteLine("een oude hond stapt");
            outputStream.WriteLine("traag trouw naast zijn baas");
            outputStream.WriteLine("samen oud wornde.");
            //sluit de connnectie
            outputStream.Close();
            MessageBox.Show("hoera");
        }

        private void readfile(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            //construeer een pad
            string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            destination = System.IO.Path.Combine(destination, "myfile.txt");

            //open een conecite naar het bestand
            StreamReader inputStream = File.OpenText(destination);
            //lees alle data
            string line = inputStream.ReadLine();
            while(line != null)
            {
                // doe iets met line
                textBox.AppendText(line + "\n");
                line = inputStream.ReadLine();
            }
            // sluit de connectie
            inputStream.Close();
        }


        private void openfile(object sender, RoutedEventArgs e)
        {
            //construeer een pad
            string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.InitialDirectory = destination;
            filedialog.Filter = "Text files|*.txt|All files|*.*";
            if (filedialog.ShowDialog() == true)
            {
                textBox.Text = "";
                StreamReader inputStream = File.OpenText(filedialog.FileName);
                string line = inputStream.ReadLine();

                while (line != null)
                {
                    // doe iets met line
                    textBox.AppendText(line + "\n");
                    line = inputStream.ReadLine();
                }
                // sluit de connectie
                inputStream.Close();
            }

        }
    }
}
