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

namespace w02e01
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

        private void gewoneButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("je hebt geklikt op een gewone button");
        }

        private void imgButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("je hebt geklikt op de image");
        }

        private void colorButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("je hebt geklikt op de kleurbutton");
        }
    }
}
