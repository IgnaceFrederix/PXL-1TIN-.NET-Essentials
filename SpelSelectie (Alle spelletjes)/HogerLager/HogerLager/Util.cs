using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HogerLager
{
    public static class Util
    {

        public static void DrawCardOnCanvas(Canvas canvas, string cardName)
        {
            //Clear the canvas first and then draw the card
            canvas.Children.Clear();
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"card_images\" + cardName + ".png", UriKind.Relative);
            bi.EndInit();
            if (bi.UriSource == null)
                throw new FileNotFoundException("Kan de afbeelding card_images\\" + cardName + "png niet tekenen");
            Image picture = new Image();
            picture.Source = bi;
            picture.Margin = new Thickness(0, 0, 0, 0);
            picture.Width = canvas.Width;
            picture.Height = canvas.Height;
            canvas.Children.Add(picture);
        }
    }
}
