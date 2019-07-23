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

namespace w01e05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int teller;
        private bool plusbool = false;
        public MainWindow()
        {
           
            InitializeComponent();
        }


        private void tel7(object sender, RoutedEventArgs e)
        {
          if(plusbool == true)
            {
               teller = teller + 7;
                plusbool = false;
            }
           
        }

        private void tel8(object sender, RoutedEventArgs e)
        {
            if (plusbool == true)
            {
                teller = teller + 8;
                plusbool = false;
            }
        }

        private void tel9(object sender, RoutedEventArgs e)
        {
            if (plusbool == true)
            {
                teller = teller + 9;
                plusbool = false;
            }
        }

        private void tel4(object sender, RoutedEventArgs e)
        {
            if (plusbool == true)
            {
                teller = teller + 4;
                plusbool = false;
            }
        }

        private void tel5(object sender, RoutedEventArgs e)
        {
            if (plusbool == true)
            {
                teller = teller + 5;
                plusbool = false;
            }
        }

        private void tel6(object sender, RoutedEventArgs e)
        {
            if (plusbool == true)
            {
                teller = teller + 6;
                plusbool = false;
            }
        }

        private void tel1(object sender, RoutedEventArgs e)
        {
            if (plusbool == true)
            {
                teller = teller + 1;
                plusbool = false;
            }
        }

        private void tel2(object sender, RoutedEventArgs e)
        {
            if (plusbool == true)
            {
                teller = teller + 2;
                plusbool = false;
            }
        }

        private void tel3(object sender, RoutedEventArgs e)
        {
            if (plusbool == true)
            {
                teller = teller + 3;
                plusbool = false;
            }
        }

        private void tel0(object sender, RoutedEventArgs e)
        {
            if (plusbool == true)
            {
                teller = teller + 3;
                plusbool = false;
            }
        }

        private void plusFuntion(object sender, RoutedEventArgs e)
        {
            plusbool = true;
        }

        private void toon(object sender, RoutedEventArgs e)
        {
            label.Content = teller;
        }
    }
}
