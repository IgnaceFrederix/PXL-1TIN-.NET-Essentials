using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CommandLineDrawing
{
    public class RectangleShape : Shape
    {
        
        public void TekenRechthoek() : base(int x, int y, int breedte, int hoogte, Color kleur)
        {
            Rectangle rect = new Rectangle();
            rect.Width = breedtevar;
            rect.Height = hoogtevar;
            rect.Margin = new Thickness(xpos, ypos, 0, 0);
            rect.Stroke = new SolidColorBrush(kleurvar);
            paperCanvas.Children.Add(rect);

        }
       

    }
}
