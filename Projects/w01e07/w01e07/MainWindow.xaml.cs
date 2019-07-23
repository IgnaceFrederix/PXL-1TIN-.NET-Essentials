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

namespace w01e07
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

        private void showIt(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("de naam van dit vak is " + textBox.Text + "\n  De starttijd is " + date1.Text + " om " + textBox1.Text + " \n en de einddatum van dit vak is op" + date2.Text + " om " + textBox2.Text);
        }
    }
}
