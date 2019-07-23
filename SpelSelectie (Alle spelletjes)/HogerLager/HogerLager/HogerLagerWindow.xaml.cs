using DomainClasses;
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
using System.Windows.Shapes;

namespace HogerLager
{
    /// <summary>
    /// Interaction logic for KoetjeMelken.xaml
    /// </summary>
    public partial class HogerLagerWindow : Window
    {
        private string[] faces;
        private string[] suits;

        public HogerLagerWindow(string[] faces, string[] suits)
        {
            InitializeComponent();

            this.faces = faces;
            this.suits = suits;

            //Add the faces
            valueSlider.Minimum = 1;
            valueSlider.Maximum = faces.Length;
            valueSlider.ValueChanged += FaceChanged;

            //Add the suits
            foreach (string s in suits)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = s;
                suitComboBox.Items.Add(item);
            }
            suitComboBox.SelectedItem = suitComboBox.Items[0];
        }

        private void FaceChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeStartingCard();
        }

        private void StartGame(object sender, RoutedEventArgs e)
        {
            int aantal;
            try
            {
                aantal = Convert.ToInt32(inputTextBox.Text);
                if (aantal < 2 || aantal > 50)
                {
                    MessageBox.Show("Je kan enkel een getal tussen 2 en 50 opgeven");
                    return;
                }
                ComboBoxItem item = (ComboBoxItem)suitComboBox.SelectedItem;
                string suit = Convert.ToString(item.Content);
                string face = faces[(int)valueSlider.Value - 1];
                Card startingCard = new Card(suit, face, (int)valueSlider.Value - 1);
                GameWindow window = new GameWindow(aantal, startingCard, faces, suits);
                window.Show();
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Je moet een geldig getal ingeven");
            }
        }

        private void ChangeStartingCard()
        {
            ComboBoxItem item = (ComboBoxItem)suitComboBox.SelectedItem;

            string suit = Convert.ToString(item.Content);
            string face = faces[(int)valueSlider.Value - 1];

            try
            {
                Util.DrawCardOnCanvas(cardCanvas, face + suit);
            }
            catch(FileNotFoundException exc)
            {
                MessageBox.Show(exc.Message, "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SuitChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeStartingCard();
        }
    }
}
