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

namespace H6_3
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

        int teller = 0;
        int som = 0;
        private void Genereer(object sender, RoutedEventArgs e)
        {
          
            double gemiddelde=0;
            int random;
           
            Random r = new Random();
            random = r.Next(200,400);
            label.Content = random;
            teller++;
            som = som + random;
            gemiddelde = som / teller;
            label1.Content = gemiddelde;
            
            label2.Content = som;
           
        }
    }
}
