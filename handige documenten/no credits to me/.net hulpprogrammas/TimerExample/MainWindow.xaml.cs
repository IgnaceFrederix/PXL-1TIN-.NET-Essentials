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

using System.Windows.Threading; //Nodig om timer te kunnen gebruiken.

namespace TimerExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer1;         //variabele timer van het type Dispatch timer
        

        public MainWindow()
        {
            InitializeComponent();

            timer1 = new DispatcherTimer();                 //zoals alle variabele die ge van een klasse aanmaakt
            timer1.Tick += new EventHandler(timer1_Tick);  //maakt een tick event aan (zie verder in code) vergelijkbaar met click-event button, alleen dat dit per interval gebeurd
            timer1.Interval = new TimeSpan(0, 0, 0, 1);                //bepalen interval timer, code in eventhandler uitvoeren PER dag/ per uur / per minuut /per seconden? 
                                                                    // eerste getal (0) wilt zeggen 0 dagen, tweede getal (0) = 0 uren, 3e getal (0) = 0 minuten, 4e getal(1) = 1seconden
                                                                    // In dit geval gaat de timer PER 1 seconden de code uitvoeren die in de eventhandler timer1_tick staat

        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            progressBar.Value = 0;   //zodat ge opnieuw de progressbar kunt laten lopen als deze vol is geweest
            timer1.Start();         //Hier wordt timer1 gestart en de code in de timer1_tick eventhandler blijven uitvoeren PER seconden tot dat ge ergens "timer1.stop()" zegt

        }
        private void timer1_Tick(object sender, EventArgs e)    //Event handler timer tick, hierin schrijft ge code wat ge wilt dat er per tijdsinteveal gebeurd, in dit geval ophogen statusbar    
        {
           

            if (progressBar.Value == progressBar.Maximum)       //if loop om te controleren of het maximum volume van de progressbar nog niet is bereikt (anders crasht de boel als deze overschreden word)
            {
                timer1.Stop();                                   //Hier word de timer op stop gezet zodat deze niet verder tikt, de code in de eventhandler timer1_tick word nu niet uitgevoerd, totdat de timer terug start
                MessageBox.Show("progressbar vol!");
            }
            else
            {
                progressBar.Value += 6;  // nu gaat de progressBar iedere seconden met 6 opgehoogd worden

            }



           
        }

        private void zelfButton_Click(object sender, RoutedEventArgs e)
        {
            if (zelfProgressbar.Value == zelfProgressbar.Maximum)    //gaat controleren of de value niet groter is dan de maxvalue, zoja word deze terug op nul gezet en wordt er een message box getoond  
            {
                                                
                MessageBox.Show("progressbar vol!");
                zelfProgressbar.Value = 0;
            }
            else
            {
                zelfProgressbar.Value += 6;   //nu gaat per klik de progressbar met 6 omhoog
            }

            
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
