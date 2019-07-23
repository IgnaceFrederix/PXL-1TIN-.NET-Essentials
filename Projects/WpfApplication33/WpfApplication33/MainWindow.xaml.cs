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

namespace WpfApplication33
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
      
        private void doit(object sender, RoutedEventArgs e)
        {
            string gezocht = search.Text;
            string vervang = replacebox.Text;
            while (vieuw.Text.Contains(gezocht))
            {
                
            } 
          
        }
        Random r = new Random();
        public void woord()
        {
           
            int groote = r.Next(0, 5);
            for(int i = 0; i < groote; i++)
            {
                int num = r.Next(0, 3);
                char let = (char)('a' + num);
                vieuw.Text += let + "";
            }
            vieuw.Text += " ";
           
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                woord();

            }
        }
    }
}
