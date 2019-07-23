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

namespace WpfApplication8
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

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            if(slider.Value + slider1.Value == 2 || slider.Value + slider1.Value == 5 || slider.Value + slider1.Value == 7)
            {

                label.Content = "you have won";
            }
            else
            {
                label.Content = "you lose";
            }
            slider1.Maximum = 6;
            slider.Maximum = 6;
        }
    }
}
