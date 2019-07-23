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

namespace T3._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void drawT(object sender, RoutedEventArgs e)
        {
            Line l1 = new Line();
            Line l2 = new Line();
            l1.X1 = 20;
            l1.Y1= 20;
            l1.X2 = 120;
            l1.Y2 = 20;
            l1.Stroke = new SolidColorBrush(Colors.Black);
            l1.StrokeThickness = 4;
            l2.X1 = 70;
            l2.Y1 = 20;
            l2.X2 = 70s;
            l2.Y2 = 120;
            l2.Stroke = new SolidColorBrush(Colors.Black);
            l2.StrokeThickness = 4;
            paper.Children.Add(l1);
            paper.Children.Add(l2);




        }
    }
}
