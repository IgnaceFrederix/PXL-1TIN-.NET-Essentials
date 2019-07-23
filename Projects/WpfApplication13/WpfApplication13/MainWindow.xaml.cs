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

namespace WpfApplication13
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

        private void ChangeApp(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            for(int i = 1; i < slider.Value; i = i++)
            {
                for(int j = 1; j < slider1.Value; j++)
                {
                    drawRect(10, 10, i, j);
                }
              
            }
            

        }
        private void drawRect(int x, int y, int xpos, int ypos)
        {
            Rectangle rect = new Rectangle();
            rect.Height = x;
            rect.Width = y;
            rect.Margin = new Thickness(50, 50, 0, 0);
            rect.Stroke =  new SolidColorBrush(Colors.Black);
            paper.Children.Add(rect);

        }
    }
}
