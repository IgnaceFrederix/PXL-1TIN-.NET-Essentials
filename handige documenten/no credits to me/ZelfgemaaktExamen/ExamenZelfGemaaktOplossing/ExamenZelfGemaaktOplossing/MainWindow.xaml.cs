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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            creeerklassen();
        }

        private ObservableCollection<Klas> klassen;
        private List<Student> studenten;

        Student student;
        

        private void RegistreerButton_Click(object sender, RoutedEventArgs e)
        {
            RegistreerWindow r = new RegistreerWindow();
            r.ShowDialog();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text.Equals("Admin") && PasswoordTextBox.Password.Equals("Admin"))
            {
               LeerkrachtenWindow l = new LeerkrachtenWindow(klassen);
               l.ShowDialog();
            }
            else if (!UsernameTextBox.Text.Equals("Admin"))
            {
                for (int i = 0; i < studenten.Count; i++)
                {
                    if (UsernameTextBox.Text.Equals(studenten[i].naam) && PasswoordTextBox.Password.Equals(studenten[i].passwoord))
                    {
                        student = studenten[i];
                        LeerlingenWindow l = new LeerlingenWindow(student);
                        l.ShowDialog();

                    }
                }
            }
            else
            {
                MessageBox.Show("Foute gebruikersnaam of wachtwoord");
            }



        }
        private void creeerklassen()
        {
            StreamReader leesleerlingen = null;
            StreamReader leesklassen = null;
            string[] split;
            string[] splits;


            klassen = new ObservableCollection<Klas>();
            studenten = new List<Student>();
            string leerlingregel;
            string klassenregel;
            leesleerlingen = new StreamReader(@"../../Leerlingen.txt", System.Text.Encoding.Default);
            leesklassen = new StreamReader(@"../../Klassen.txt", System.Text.Encoding.Default);
            klassenregel = leesklassen.ReadLine();
            leerlingregel = leesleerlingen.ReadLine();
            while (klassenregel != null)
            {
                split = klassenregel.Split(',');
                Klas klas = new Klas(split[1], split[0]);
                for (int i = 0; i < 4; i++)
                {
                    splits = leerlingregel.Split(',');
                    leerlingregel = leesleerlingen.ReadLine();
                    if (klas.kortnaam == (splits[0]))
                    {
                        studenten.Add(new Student(Convert.ToChar(splits[0]),splits[1], splits[2], splits[3]));
                        klas.studenten.Add(new Student(Convert.ToChar(splits[0]),splits[1], splits[2], splits[3]));
                        klas.hoeveel++;
                    }
                }
                klassenregel = leesklassen.ReadLine();
                klassen.Add(klas);
            }
            leesleerlingen.Close();
            leesklassen.Close();
        }
    }
}
