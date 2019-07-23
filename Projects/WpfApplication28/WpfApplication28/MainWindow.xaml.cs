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

namespace WpfApplication28
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

        private void searchbutton(object sender, RoutedEventArgs e)
        {
            string sourcepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string line = "";
            string[] words = new string[3];
            bool found = false;
            StreamReader inputStream = null;
            label.Content = "";
            label1.Content = "";
            if(textBox.Text == "")
            {
                MessageBox.Show("er is geen pad meegegeven");
            }
            else if(textBox1.Text =="")
            {
                MessageBox.Show(" er is geen naam meegeeven");
            }
            else
            {
                string fileToSearch = System.IO.Path.Combine(sourcepath.textBox.text);
                inputStream = File.OpenText(fileToSearch);
                char separator = '.';
                line = inputStream.ReadLine();
                while((line != null) && ((!found))){
                    words = line.Split(separator);
                }
                }
            }
        }
    }

