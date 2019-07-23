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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace InputstreamVoorbeeld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numberOfLines;
        public MainWindow()
        {
            InitializeComponent();
        }
        public string[] words;
       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string sourcepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string myfile = System.IO.Path.Combine(sourcepath, "test.txt");
            StreamReader inputstream = File.OpenText(myfile);
            numberOfLines = File.ReadLines(myfile).Count();             //telt de regels van het document //Dit moet niet! je kan ook zo programmeren:
                                                                        //while(listlines.readline() != null)
                                                                        //words = listlines.readline().split(',')...
           
            string[] ListLines = new string[numberOfLines];         //hierin komen alle regels





            for (int i = 0; i < numberOfLines; i++)  //gaat de regels opsplitsen
            {
                ListLines[i] = inputstream.ReadLine();   //hierin worden de regels weggeschreven, gebruik split methoden als ge verschillende waardes in een array wilt laden    
                
            }
            inputstream.Close();        //sluit de inputstream

            int z = 0;
                words = ListLines[z].Split(';');
                for(int j = 0; j < words.Length; j++){
                TextBox1.AppendText(words[j]);
                }
                TextBox1.AppendText(Environment.NewLine);
            z++;
            

        }
    }
}
