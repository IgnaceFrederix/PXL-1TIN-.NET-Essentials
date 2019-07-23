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

namespace WpfApplication7
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
            DrawLogo(40,60);
            DrawLogo(100, 60);
            DrawDriehoek(20,55,95,2);
            DrawDriehoek(170, 55, 95, 2);
        }
        private void DrawDriehoek(int xpos, int ypos, int xpos2, int ypos2)
        {
            DrawLine(xpos, ypos, xpos2, ypos2);
            DrawLine(xpos, ypos, xpos2, ypos);
            DrawLine(xpos2, ypos, xpos2, ypos2);
        }

        private void DrawLogo(int xPos, int yPos)
        {
            DrawBlackSquare(20, xPos, yPos, paper);
            DrawBlackSquare(40, xPos, yPos, paper);
            DrawBlackSquare(60, xPos, yPos, paper);
        }
        private void DrawLine(int x, int y, int x2, int y2)
        {
            Line l1 = new Line();
            
            l1.X1 = x;
            l1.X2 = x2;
            l1.Y1 = y;
            l1.Y2 = y2;
            l1.Margin = new Thickness(5, 5, 0, 0);
            l1.Stroke = new SolidColorBrush(Colors.Black);
            paper.Children.Add(l1);



        }

        private void DrawBlackSquare(double size, int x, int y, Canvas canvas)
        {
            Rectangle rect = new Rectangle();
            rect.Width = size;
            rect.Height = size;
            rect.Margin = new Thickness(x, y, 0, 0);
            rect.Stroke = new SolidColorBrush(Colors.Black);
            canvas.Children.Add(rect);

        }
    }
}
