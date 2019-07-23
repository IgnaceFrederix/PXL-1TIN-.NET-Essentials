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
using System.Windows.Shapes;

namespace ExamenZelfGemaaktOplossing
{
    /// <summary>
    /// Interaction logic for GeefPuntenWindow.xaml
    /// </summary>
    public partial class GeefPuntenWindow : Window
    {
        Klas klas;
        int index;
        public GeefPuntenWindow(Klas klas, int index)
        {
            InitializeComponent();
            this.klas = klas;
            this.index = index;

        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            klas.studenten[index].punten[0] += Convert.ToInt32(Punt1TextBox.Text);
            klas.studenten[index].punten[1] += Convert.ToInt32(Punt2TextBox.Text);
            klas.studenten[index].punten[2] += Convert.ToInt32(Punt3TextBox.Text);
            this.Close();
        }

    }
}
