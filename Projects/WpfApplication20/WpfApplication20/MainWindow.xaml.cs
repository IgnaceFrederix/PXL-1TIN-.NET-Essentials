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

namespace WpfApplication20
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

        private void berekenen(object sender, RoutedEventArgs e)
        {
            try
            {
                string email = textBox.Text;
                bool isMailadress = isMail(email);
                int getal = Convert.ToInt32(textBox.Text);
                int resultaat = 100 / getal;
                label.Content = "" + resultaat;
                isMail
            }
            catch(Exception exc)
            {
                label.Content = exc.Message;
            }
            finally
            {
                MessageBox.Show("dit is finely");
            }
          
         
        }

        public bool isMail(string adres)
        {
            if (adres.Contains('@'))
            {
                return true;
            }
            return false;
        }
    }
}
