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

namespace WpfApplication26
{
    /// <summary>
    /// Interaction logic for secwindow.xaml
    /// </summary>
    public partial class secwindow : Window
    {
        private MainWindow mainwindow;
        public secwindow(MainWindow mainwindow)
        {
            InitializeComponent();
            this.mainwindow = mainwindow;
        }

        private void closewindow(object sender, RoutedEventArgs e)
        {
            mainwindow.Close();
        }

        private void hidewindow(object sender, RoutedEventArgs e)
        {
            mainwindow.Hide();
        }
    }
}
