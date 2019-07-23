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

namespace _3._6
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
            Ellipse e1 = new Ellipse();
            e1.Height = 200;
            e1.Width = 150;
            e1.Margin = new Thickness(10, 10, 0, 0);
            e1.Stroke = new SolidColorBrush(Colors.Black);
            paper.Children.Add(e1);

            Ellipse e2 = new Ellipse();
            e2.Height = 10;
            e2.Width = 10;
            e2.Margin = new Thickness(50, 40, 10, 0);
            e2.Stroke = new SolidColorBrush(Colors.Black);
            paper.Children.Add(e2);

            Ellipse e3 = new Ellipse();
            e3.Height = 10;
            e3.Width = 10;
            e3.Margin = new Thickness(100, 40, 10, 0);
            e3.Stroke = new SolidColorBrush(Colors.Black);
            paper.Children.Add(e3);

            Ellipse e4 = new Ellipse();
            e4.Height = 5;
            e4.Width = 20;
            e4.Margin = new Thickness(70, 100, 10, 0);
            e4.Stroke = new SolidColorBrush(Colors.Black);
            paper.Children.Add(e4);



        }
    }
}
