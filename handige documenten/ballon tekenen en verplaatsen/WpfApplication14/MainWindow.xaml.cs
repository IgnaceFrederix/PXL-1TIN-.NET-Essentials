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

namespace WpfApplication14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Balloon ballon;
      

        public MainWindow()
        {
            InitializeComponent();

            ballon = new Balloon();
           
            ballon.Grow(10);
            ballon.DrawOnCanvas(paper);
           

            
        }
    
        private void Growballon(object sender, RoutedEventArgs e)
        {
            ballon.Grow(10);
        }

        private void right(object sender, RoutedEventArgs e)
        {
            ballon.moveRight(2);
        }
        
        private void moveupbutton(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(textBox.Text);
            ballon.moveUp(x);
        }

        private void changeColor(object sender, RoutedEventArgs e)
        {
            Color kleur = Colors.BlueViolet;
            
            ballon.Color(kleur);
                
        }

        private void UpdateEllipse(object sender, RoutedEventArgs e)
        {
            
        }
        public void Balloon (int x, int y, Colors color)
        {
            
        }

    }
}
