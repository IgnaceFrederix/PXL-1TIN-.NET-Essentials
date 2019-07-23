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

namespace Oef14_9_Statistieken
{
    public partial class Form1 : Form
    {
        private int aantal = 100;
        private int[] rij;
        // frequentietabel
        private int[] freq = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(System.Object sender, System.EventArgs e)
        {
            rij = MaakRij(aantal);
            for (int i = 0; i < freq.Length; i++)
            {
                freq[i] = 0;
            }
            BerekenFrequenties(rij, freq);
            TekenStaafDiagram(chartPictureBox, freq);
            grootsteLabel.Text = "Grootste: " + Grootste(rij);
            kleinsteLabel.Text = "Kleinste: " + Kleinste(rij);
            somLabel.Text = "Som: " + Som(rij);
            gemiddeldeLabel.Text = "Gemiddelde: " + Gemiddelde(rij);
        }

        private int[] MaakRij(int aantal)
        {
            int[] r = new int[aantal];
            Random random = new Random();
            for (int i = 0; i < r.Length; i++)
            {
                r[i] = random.Next(1, 100);
            }
            return r;
        }

        private int Grootste(int[] rij)
        {
            return Max(rij);
        }

        private int Kleinste(int[] rij)
        {
            int m = rij[0];
            for (int i = 1; i < rij.Length; i++)
            {
                if (rij[i] < m)
                {
                    m = rij[i];
                }
            }
            return m;
        }

        private int Som(int[] rij)
        {
            int s = 0;
            for (int i = 0; i < rij.Length; i++)
            {
                s = s + rij[i];
            }
            return s;
        }

        private double Gemiddelde(int[] rij)
        {
            return Som(rij) / rij.Length;
        }

        private void BerekenFrequenties(int[] r, int[] f)
        {

            for (int i = 0; i < r.Length; i++)
            {
                switch (r[i])
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        f[0] = f[0] + 1;
                        break;
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                        f[1] = f[1] + 1;
                        break;
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                    case 24:
                    case 25:
                    case 26:
                    case 27:
                    case 28:
                    case 29:
                        f[2] = f[2] + 1;
                        break;
                    case 30:
                    case 31:
                    case 32:
                    case 33:
                    case 34:
                    case 35:
                    case 36:
                    case 37:
                    case 38:
                    case 39:
                        f[3] = f[3] + 1;
                        break;
                    case 40:
                    case 41:
                    case 42:
                    case 43:
                    case 44:
                    case 45:
                    case 46:
                    case 47:
                    case 48:
                    case 49:
                        f[4] = f[4] + 1;
                        break;
                    case 50:
                    case 51:
                    case 52:
                    case 53:
                    case 54:
                    case 55:
                    case 56:
                    case 57:
                    case 58:
                    case 59:
                        f[5] = f[5] + 1;
                        break;
                    case 60:
                    case 61:
                    case 62:
                    case 63:
                    case 64:
                    case 65:
                    case 66:
                    case 67:
                    case 68:
                    case 69:
                        f[6] = f[6] + 1;
                        break;
                    case 70:
                    case 71:
                    case 72:
                    case 73:
                    case 74:
                    case 75:
                    case 76:
                    case 77:
                    case 78:
                    case 79:
                        f[7] = f[7] + 1;
                        break;
                    case 80:
                    case 81:
                    case 82:
                    case 83:
                    case 84:
                    case 85:
                    case 86:
                    case 87:
                    case 88:
                    case 89:
                        f[8] = f[8] + 1;
                        break;
                    case 90:
                    case 91:
                    case 92:
                    case 93:
                    case 94:
                    case 95:
                    case 96:
                    case 97:
                    case 98:
                    case 99:
                        f[9] = f[9] + 1;
                        break;
                }

            }
        }

        private void TekenStaafDiagram(PictureBox pbox, int[] rij)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            Graphics area = pbox.CreateGraphics();
            area.Clear(Color.White);
            int u_width = Convert.ToInt32(pbox.Width / (rij.Length * 2.0 + 1));
            int u_height = Convert.ToInt32(pbox.Height / (Max(rij) * 1.2));
            // veronderstel dat de grootste waarde in de rij bijna de grootst mogelijke waarde is

            for (int i = 0; i < rij.Length; i++)
            {
                area.FillRectangle(brush, (2 * i + 1) * u_width,
                                   pbox.Height - rij[i] * u_height,
                                   u_width,
                                   rij[i] * u_height);
            }
        }

        // Berekent het maximum van een rij
        private int Max(int[] rij)
        {
            int m = rij[0];
            for (int i = 1; i < rij.Length; i++)
            {
                if (m < rij[i])
                {
                    m = rij[i];
                }
            }
            return m;
        }
    }
}
