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

namespace w01e06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool start;
        

        public MainWindow()
        {
            InitializeComponent();
            start = false;
        }

        private void changeSelectiont(object sender, SelectionChangedEventArgs e)
        {
            if (start == true)
            {
                listBox.SelectedIndex = comboBox1.SelectedIndex;
            }
        }

        private void changeSelectionlistbox(object sender, SelectionChangedEventArgs e)
        {
            if (start == true)
            {
                comboBox1.SelectedIndex = listBox.SelectedIndex;
                MessageBox.Show(Convert.ToString(listBox.SelectedIndex));
            }
        }


        private void test(object sender, MouseEventArgs e)
        {
            start = true;
        }

  

      
    }
}
