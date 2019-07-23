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
    /// Interaction logic for LeerlingenWindow.xaml
    /// </summary>
    public partial class LeerlingenWindow : Window
    {
        
        Student student;
        public LeerlingenWindow(Student student)
        {
            InitializeComponent();
            this.student = student;
            verdeelpunten();
        }
        private void verdeelpunten()
        {

            Punt1Label.Content = "16";
            Punt2Label.Content = "13";
            Punt3Label.Content = "8";
            
            //else
            //{
            //    Punt1Label.Content = "0";
            //    Punt2Label.Content = "0";
            //    Punt3Label.Content = "0";
            //}
            NaamLabel.Content = student.naam;
        }

        private void LogUitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
