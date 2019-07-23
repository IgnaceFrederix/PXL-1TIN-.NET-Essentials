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

namespace testfileexamen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
  
    public partial class MainWindow : Window
    {

        private int saldo;
        
        // Constructor
     
        // Methodes
        public void Storting(int waarde)
        {
            saldo = 2;
            saldo = saldo + waarde;
        }

        public void Opname(int waarde)
        {
            saldo = saldo - waarde;
        }

        // Property
        public int HuidigSaldo
        {
            get
            {
                return saldo;
            }
        }
        public void setsaldo()
        {
            HuidigSaldo.ToString;
        }
        MessageBox.Show();
    }
}
