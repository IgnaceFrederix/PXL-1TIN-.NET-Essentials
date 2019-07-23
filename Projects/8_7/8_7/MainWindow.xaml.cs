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

namespace _8_7
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

        private void maal(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(textBox.Text);

           
                for (int i = 1; i<= x; i++)
            {

                   
               
                label.Content += i + "\t";

                for (int j = 1; j <= x; j++)
                    {

                        label.Content += j * i + "\t";

                 
                     }
                
                label.Content +=  "\n";

               
            }
                
            
        }
    }
}
