//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Oef15_7_ConwaySpel
{
    /// <summary>
    /// zie ook: http://en.wikipedia.org/wiki/Conway's_Game_of_Life
    /// </summary>
    public partial class Form1 : Form
    {
        // aantal rijen = aantal kolommen
        private const int DIMENSIE = 32;
        // breedte = hoogte van een blokje op pbBord
        private int unit;
        // bord met "" (dood) of "*" (levend)
        private string[,] bord = new string[DIMENSIE + 2, DIMENSIE + 2];
        // boven/onder/links/rechts dode sentinel elementen


        public Form1()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            unit = Convert.ToInt32(bordPictureBox.Width / DIMENSIE);

            // allemaal dode cellen
            for (int i = 0; i < bord.GetLength(0); i++)
            {
                for (int j = 0; j < bord.GetLength(1); j++)
                {
                    bord[i, j] = string.Empty;
                }
            }
        }

        private void TekenBord(Graphics area)
        {
            for (int i = 1; i < bord.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < bord.GetLength(1) - 1; j++)
                {
                    if (bord[i, j] == "*")
                    {
                        TekenVierkant(area, (j - 1) * unit, (i - 1) * unit);
                    }
                }
            }

        }

        private void TekenVierkant(Graphics area, int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.BlueViolet);

            area.FillRectangle(brush, x, y, unit, unit);
        }

        private void TekenRaster(Graphics area)
        {
            Pen pen = new Pen(Color.Black);
            // rijen
            for (int i = 0; i <= DIMENSIE; i++)
            {
                area.DrawLine(pen, i * unit, 0, i * unit, bordPictureBox.Height);
            }

            //kolommen
            for (int j = 0; j <= DIMENSIE; j++)
            {
                area.DrawLine(pen, 0, j * unit, bordPictureBox.Width, j * unit);
            }
        }

        private void pbBord_Click(object sender, EventArgs e)
        {
            MouseEventArgs ev = (MouseEventArgs)e;
            int rij = ev.Location.Y / unit + 1;
            int kolom = ev.Location.X / unit + 1;
            
            bord[rij, kolom] = "*";

            bordPictureBox.Invalidate();
        }


        private void pbBord_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            TekenRaster(e.Graphics);
            TekenBord(e.Graphics);
        }


        private void nextButton_Click(System.Object sender, System.EventArgs e)
        {
            BerekenStap();
            bordPictureBox.Invalidate();
        }

        private void BerekenStap()
        {
            string[,] tempBord = new string[bord.GetLength(0), bord.GetLength(1)];
            for (int i = 0; i < tempBord.GetLength(0); i++)
            {
                for (int j = 0; j < tempBord.GetLength(1); j++)
                {
                    tempBord[i, j] = string.Empty;
                }
            }

            for (int i = 1; i < tempBord.GetLength(0) - 1; i++)
            {

                for (int j = 1; j < tempBord.GetLength(1) - 1; j++)
                {
                    // Any live cell with fewer than two live neighbours dies, as if caused by underpopulation. 
                    if (bord[i, j] == "*" && AantalLevendeBuren(i, j, bord) < 2)
                    {
                        tempBord[i, j] = "";
                    }

                    // Any live cell with more than three live neighbours dies, as if by overcrowding.
                    if (bord[i, j] == "*" && AantalLevendeBuren(i, j, bord) > 3)
                    {
                        tempBord[i, j] = "";
                    }

                    // Any live cell with two or three live neighbours lives on to the next generation.
                    if (bord[i, j] == "*" && (AantalLevendeBuren(i, j, bord) == 3 || AantalLevendeBuren(i, j, bord) == 2))
                    {
                        tempBord[i, j] = "*";
                    }

                    // Any dead cell with exactly three live neighbours becomes a live cell. 
                    if (string.IsNullOrEmpty(bord[i, j]) && AantalLevendeBuren(i, j, bord) == 3)
                    {
                        tempBord[i, j] = "*";
                    }

                }
            }

            bord = tempBord;
        }

        private int AantalLevendeBuren(int i, int j, string[,] b)
        {
            int s = 0;

            for (int p = i - 1; p <= i + 1; p++)
            {
                for (int q = j - 1; q <= j + 1; q++)
                {
                    if (p != i || q != j)
                    {
                        if (b[p, q] == "*")
                        {
                            s += 1;
                        }
                    }
                }
            }
            return s;
        }
    }
}
