//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Oef10_5_Dobbelstenen
{
    /// <summary>
    /// Dobbelsteen
    /// </summary>
    public class Dobbelsteen
    {
        private Random randomNumber;
        private static int seed = DateTime.Now.Millisecond;

        public Dobbelsteen()
        {
            randomNumber = new Random(seed);
            seed = seed + new Random().Next(1, 1000);
        }

        public int Werp()
        {
            int worp;
            worp = randomNumber.Next(1, 7);
            return worp;
        }

        public void ToonDobbelsteen(PictureBox drawArea, int worp)
        {
            Image foto = null;

            switch (worp)
            {
                case 1: foto=new Bitmap("een.png");
                break;
                case 2: foto = new Bitmap("twee.png");
                break;
                case 3: foto = new Bitmap("drie.png");
                break;
                case 4: foto = new Bitmap("vier.png");
                break;
                case 5: foto = new Bitmap("vijf.png");
                break;
                case 6: foto = new Bitmap("zes.png");
                break;
            }
            drawArea.Image = foto;
        }
    }
}
