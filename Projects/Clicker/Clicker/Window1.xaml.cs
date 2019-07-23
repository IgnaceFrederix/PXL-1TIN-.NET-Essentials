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

namespace Clicker
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
      
        public int test;
        public Window1()
        {
            InitializeComponent();

            quittext.Content = "Would you really like to quit ? \nWould you let ISIS conquer our lands ?";
            if(test == 1)
            {
                this.Close();
            }



        }

        private void yesquit(object sender, RoutedEventArgs e)
        {
            test = 1;
           
            this.Close();
            
           
        }

        private void noquit(object sender, RoutedEventArgs e)
        {
            this.Close();
            test = 0;
        }

    }
}
