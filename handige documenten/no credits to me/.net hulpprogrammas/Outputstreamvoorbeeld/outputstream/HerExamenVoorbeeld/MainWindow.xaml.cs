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
using System.IO; //nodig om met bestanden te werken
//using System.ComponentModel;
using System.Diagnostics; //nodug voor shortcut naar file

namespace HerExamenVoorbeeld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string destination;         //file-locatie naar mydocuments
        private string newFile;             //file-locatie+ bestandsnaam
        private StreamWriter inputStream;   //een streamWRITER, voor zaken weg te schrijven, tov een streamREADER om dingen in te lezen

        public MainWindow()
        {
            InitializeComponent();
            destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);     //pad naar mydocument   
            newFile = System.IO.Path.Combine(destination, "DEMO_Wegschrijven.txt");             //pad naar document in my documents
            
        }
      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);     //pad naar mydocument   
            newFile = System.IO.Path.Combine(destination, "DEMO_Wegschrijven.txt");             //pad naar document in my documents

            if (!File.Exists(newFile))                  //gaat kijken of file bestaat, zoniet maakt hij er die aan
            {
                File.CreateText(newFile).Close();


            }
            
            inputStream = File.AppendText(newFile);     //hier zegt ge dat ge de file wilt aanvullen (appenden)
            inputStream.WriteLine(naamTextbox.Text + ";" + passwoordTextbox.Text + ";" + adressTextbox.Text); //hier zegt ge schrijf mij een nieuwe lijn met deze waardes
            inputStream.Close();            //hier sluit ge de file terug. Belangrijke regel, want zonder gaat uw programma ook nog werken, ma als dit niet gesloten word gaat dit op de achtergrond blijven runnen = niet goed!



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (File.Exists(newFile))
            {
                Process.Start(newFile);         //opent/run filelocatie voor u, gewoon dat ge niet zelf de hele tijd naar mydocuments moet gaan
            }
        }
    }
}
