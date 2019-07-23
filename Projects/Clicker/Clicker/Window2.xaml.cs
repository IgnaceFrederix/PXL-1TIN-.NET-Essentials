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
using System.Windows.Threading;

namespace Clicker
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public double speed1;
        public double speed2;
        public double speed3;
        public double speed4;
        public double speed5;
        public double speed6;
        public double speed7;
        public double speedAll;
           
        public bool button1WasClicked = false;
        public bool button2WasClicked = false;
        public bool button3WasClicked = false;
        public bool button4WasClicked = false;
        public bool button5WasClicked = false;
        public bool button6WasClicked = false;
        public bool button7WasClicked = false;
        public bool buttonAllWasClicked = false;

        public Window2()
        {
            InitializeComponent();
            

        }

  

        private void closespeedup(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void speedup1(object sender, RoutedEventArgs e)
        {
            speed1 = 0.5;      
            button1WasClicked = true;

            
        }

        private void speedup2(object sender, RoutedEventArgs e)
        {
            speed2 = 0.5;       
            button2WasClicked = true;
        }

        private void speedup3(object sender, RoutedEventArgs e)
        {
            speed3 = 0.5;         
            button3WasClicked = true;
        }

        private void speedup4(object sender, RoutedEventArgs e)
        {
            speed4 = 0.5;         
            button4WasClicked = true;
        }

        private void speedup5(object sender, RoutedEventArgs e)
        {
            speed5 = 0.5;           
            button5WasClicked = true;
        }

        private void speedup6(object sender, RoutedEventArgs e)
        {
            speed6 = 0.5;          
            button6WasClicked = true;
        }

        private void speedup7(object sender, RoutedEventArgs e)
        {
            speed7 = 0.5;        
            button7WasClicked = true;
        }

        private void speedupAll(object sender, RoutedEventArgs e)
        {
            speedAll = 0.5;
            buttonAllWasClicked = true;
        }

    }
}
