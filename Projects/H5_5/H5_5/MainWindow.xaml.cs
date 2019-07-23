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

namespace H5_5
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Polygon p1 = new Polygon();
            p1.Width = 50;
            p1.Height = 40;
            p1.Margin = new Thickness(5, 5, 0, 0);
            p1.Stroke = new SolidColorBrush(Colors.Black);
            paper.Children.Add(p1);

            Polygon p1 = new Polygon();
            System.Windows.Point Point1 = new System.Windows.Point(1, 50);
            System.Windows.Point Point2 = new System.Windows.Point(10, 80);
            System.Windows.Point Point3 = new System.Windows.Point(50, 50);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            p1.Points = myPointCollection;
            p1.Margin = new Thickness(5, 5, 0, 0);
            p1.Stroke = new SolidColorBrush(Colors.DeepPink);
            paper.Children.Add(p1);


        }
    }
}
