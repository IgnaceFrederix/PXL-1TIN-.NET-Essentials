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

namespace WpfApplication32
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

        private void compare(object sender, RoutedEventArgs e)
        {
            string string1 = string1box.Text;
            string string2 = string2box.Text;
            string[] words = " ";
        
            label.Content += string1.ToLower()+"\n";
            label.Content += string1.ToUpper()+"\n";
            label.Content += string1.Trim('a');
            label.Content += string1.Insert(5, string2);
            label.Content += string1.Remove(6);
            label.Content += string1.Length;
            label.Content += string1.Substring(4);
            label.Content += string1.IndexOf();
            label.Content += string1.Split('a', );
            label.Content += string1.LastIndexOf('a');





        }
    }
}
