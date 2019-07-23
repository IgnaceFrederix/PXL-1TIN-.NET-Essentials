using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace w01e08
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

 


        private void testnumber(object sender, KeyEventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, @"^[0-9]+$"))
            {
                textBox1.Text = "";
            }
        }

        private void controlText(object sender, KeyEventArgs e)
        {
            if (!Regex.IsMatch(textBox.Text, @"^[a-zA-Z]+$"))
            {
                textBox.Text = "";
            }
        }
    }
}
