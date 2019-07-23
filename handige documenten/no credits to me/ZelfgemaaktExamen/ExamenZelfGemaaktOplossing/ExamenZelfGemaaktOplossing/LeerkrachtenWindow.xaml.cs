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
    /// Interaction logic for LeerkrachtenWindow.xaml
    /// </summary>
    public partial class LeerkrachtenWindow : Window
    {
        private ObservableCollection<Klas> klassen;
        public LeerkrachtenWindow(ObservableCollection<Klas> klassen)
        {
            InitializeComponent();
            this.klassen = klassen;
        }

        private void verdeelKlassen()
        {
            KlassenListBox.ItemsSource = klassen;
        }

        private void OpenItem_Click(object sender, RoutedEventArgs e)
        {
            verdeelKlassen();
        }

        private void KlassenListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Klas klas = (Klas) KlassenListBox.SelectedItem;
            LeerlingenListBox.Items.Clear();
            for (int i = 0; i < klas.hoeveel; i++)
            {
                LeerlingenListBox.Items.Add(klas.studenten[i].naam);
            }

        }

        private void LeerlingenListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Klas klas = (Klas)KlassenListBox.SelectedItem;
            int index = KlassenListBox.SelectedIndex;
            GeefPuntenWindow g = new GeefPuntenWindow(klas,index);
            g.ShowDialog();
        }

        private void LogUitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
