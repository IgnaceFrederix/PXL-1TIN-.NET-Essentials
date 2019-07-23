using System;
using System.Collections.Generic;
using System.IO;
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
using System.Collections.ObjectModel;

namespace ExamenZelfGemaaktOplossing
{
    /// <summary>
    /// Interaction logic for RegistreerWindow.xaml
    /// </summary>
    public partial class RegistreerWindow : Window
    {
       
        public RegistreerWindow()
        {
            InitializeComponent();
        }
        StreamWriter leesLeerling = null;
        string bestand;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bestand = @"../../Leerlingen.txt";
            leesLeerling = File.AppendText(bestand);
            string tekst = NaamTextBox.Text+","+PasswoordTextBox.Password+","+DatumTextBox.Text+","+KlasTextbox.Text;
            leesLeerling.WriteLine("\n"+tekst);
            leesLeerling.Close();
            this.Close();
        }

    }
}
