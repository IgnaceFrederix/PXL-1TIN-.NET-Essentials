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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {

        public int profit1;
        public int profit2;
        public int profit3;
        public int profit4;
        public int profit5;
        public int profit6;
        public int profit7;
        public int profitAll;

        public bool button1profitWasClicked = false;
        public bool button2profitWasClicked = false;
        public bool button3profitWasClicked = false;
        public bool button4profitWasClicked = false;
        public bool button5profitWasClicked = false;
        public bool button6profitWasClicked = false;
        public bool button7profitWasClicked = false;
        public bool buttonAllprofitWasClicked = false;


        public Window3()
        {
            InitializeComponent();
        }

        private void profitup1(object sender, RoutedEventArgs e)
        {
            profit1 = 2;
            button1profitWasClicked = true;
        }

        private void profitup2(object sender, RoutedEventArgs e)
        {
            profit2 = 2;
            button2profitWasClicked = true;
        }

        private void profitup3(object sender, RoutedEventArgs e)
        {
            profit3 = 2;
            button3profitWasClicked = true;
        }

        private void profitup4(object sender, RoutedEventArgs e)
        {
            profit4 = 2;
            button4profitWasClicked = true;
        }

        private void profitup5(object sender, RoutedEventArgs e)
        {
            profit5 = 2;
            button5profitWasClicked = true;
        }

        private void profitup6(object sender, RoutedEventArgs e)
        {
            profit6 = 2;
            button6profitWasClicked = true;
        }

        private void profitup7(object sender, RoutedEventArgs e)
        {
            profit7 = 2;
            button7profitWasClicked = true;
        }

        private void profitupAll(object sender, RoutedEventArgs e)
        {
            profitAll = 2;
            buttonAllprofitWasClicked = true;
        }

        private void closeprofitup(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }


    }
}
