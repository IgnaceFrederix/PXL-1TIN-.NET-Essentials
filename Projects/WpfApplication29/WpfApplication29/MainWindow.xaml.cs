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

namespace WpfApplication29
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string,Course>mytestdictonery;

        public MainWindow()
        {
            InitializeComponent();
            mytestdictonery = new Dictionary<string, Course>();

            Course cours1 = new Course(".net", "testname", 0);
            Course cours2 = new Course(".net2", "testname2", 0);

            mytestdictonery.Add(cours1.Name, cours1);
            mytestdictonery.Add(cours2.Name, cours2);
            
        }
        public class Course{

            public string Name { get; set; }
        public string Teacher { get; set; }
        public int Hours { get; set; }
        
        public Course(string name, string teacher, int hours)
        {
            Name = name;
            Teacher = teacher;
            Hours = hours;
        }

        public override string ToString()
        {
            return Name + Teacher + Hours;
                
        }

        private void Swithc(object sender, RoutedEventArgs e)
        {
               
        }
    
    }
            
    }
}
