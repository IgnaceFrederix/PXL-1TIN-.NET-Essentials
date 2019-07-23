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

namespace _8_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            drawtria();
        }
        public void drawtria()
        {
                for(int i = 1; i <=6; i++)
            {
                    for(int j =6; j >=i; j--)
                {
                    drawRect(30, 30, i*35, j*35);
                }
       
            }
        }
        public void drawRect(int x, int y, int xpos, int ypos)
        {
            Rectangle rect = new Rectangle();
            rect.Height = x;
            rect.Width = y;
            rect.Margin = new Thickness(xpos, ypos, 0, 0);
            rect.Stroke = new SolidColorBrush(Colors.Black);
            paper.Children.Add(rect);  
        }
    }
}
