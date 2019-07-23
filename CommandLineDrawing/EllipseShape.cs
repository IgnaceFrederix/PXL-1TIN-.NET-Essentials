using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CommandLineDrawing
{
    public class EllipseShape :Shape
    {
        Canvas paperCanvas;
        public void  TekenEllipse() : base(int x, int y, int breedte, int hoogte, Color kleur)
        {
            
            Ellipse elli = new Ellipse();
            elli.Width = breedtevar;
            elli.Height = hoogtevar;
            elli.Margin = new Thickness(xpos, ypos, 0, 0);
            elli.Stroke = new SolidColorBrush(kleurvar);
            paperCanvas.Children.Add(elli);

        }
    }
}
