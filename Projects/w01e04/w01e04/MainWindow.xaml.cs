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

namespace w01e04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            comboBox1.SelectedItem = 2;
            
        }

        private void setdefault(object sender, EventArgs e)
        {
            
        }

        private void changeSelection(object sender, SelectionChangedEventArgs e)
        {
            label.Content = comboBox1.Text;
        }
    }
}
