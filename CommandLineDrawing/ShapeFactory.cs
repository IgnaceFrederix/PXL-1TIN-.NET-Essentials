using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Media;

namespace CommandLineDrawing
{
    public static class ShapeFactory
    {
        public void testvorm()
        {
            try
            {
                if (commandTextBox.Text.Contains("rechthoek"))
                {
                    RectangleShape rect = new RectangleShape();
                    rect.TekenRechthoek();
                }
                else if (commandTextBox.Text.Contains("ellips"))
                {
                    EllipseShape elli = new EllipseShape();
                    elli.TekenEllipse();
                }
            }
            catch (IllegalShapeException ex)
            {

                MessageBox.Show(commandTextBox.Text + " is een onbekende vorm.");
            }

        }
    }
}
