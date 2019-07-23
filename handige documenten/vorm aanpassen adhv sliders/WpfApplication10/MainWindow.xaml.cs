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

namespace WpfApplication10
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
       
        

        private void changewith(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
            elipce.Width = slider1.Value;
            label1.Content = slider1.Value;
            slider1.Minimum = 0;
            slider1.Maximum = paper.Width;
        }

        private void changeLenght(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            elipce.Height = slider.Value;
            label.Content = slider.Value;
            slider.Minimum = 0;
            slider.Maximum = paper.Height;
        }
    }
}
