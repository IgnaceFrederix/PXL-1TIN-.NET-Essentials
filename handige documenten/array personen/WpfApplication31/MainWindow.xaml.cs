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

namespace WpfApplication31
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
        private int[] rij;
        private Persoon[] personen;



        private void iets(object sender, RoutedEventArgs e)
        {

            personen = new Persoon[2]
           {
                new Persoon("test1",27),
                new Persoon("test2",55)
           };

            textBlock.Text = "";
            rij = new int[] { 1, 2, 3, 4 };
            for(int i = 0; i< personen.Length; i++)
            {
                textBlock.Text += String.Format (personen[i].Name +" nog een leeftijd"+ personen[i].Age +"\n" );
            }



           



        }

    }
}
