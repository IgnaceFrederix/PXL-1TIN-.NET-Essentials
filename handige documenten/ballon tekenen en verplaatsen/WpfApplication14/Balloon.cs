using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;


namespace WpfApplication14
{
    class Balloon
    {
        private int diameter = 20;
        private int x = 50;
        private int y = 50;
      //  private Colors color = c
        private Ellipse ellipse;
        Color color;



        public Balloon()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = new SolidColorBrush(Colors.Red);
            ellipse.StrokeThickness = 2;
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }

        public void Grow(int change)
        {
            diameter = diameter + change;
            UpdateElipce();
        }

        public void DrawOnCanvas(Canvas paper)
        {
            paper.Children.Add(ellipse);
        }
        public void moveRight(int ammount)
        {
            x = x + ammount;
            UpdateElipce();
        }
        
        public void moveUp(int up)
        {
            y = y - up ;
            UpdateElipce();
        }
        public void Color()
        {


            UpdateElipce();
        }

        public void UpdateElipce()
        {
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Stroke = new SolidColorBrush(color);
        }

    }
}
