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

namespace w02e03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         r1. =    new SolidColorBrush(Colors.Yellow);
        }

        private void grow(object sender, RoutedEventArgs e)
        {
            r1.Height = r1.Height + 10;
            r1.Width = r1.Width + 10;
        }

        private void shrink(object sender, RoutedEventArgs e)
        {
            if(r1.Height >10 && r1.Width >10)
            {
                r1.Height = r1.Height - 10;
                r1.Width = r1.Width - 10;
            }
           
        }
    }
}
