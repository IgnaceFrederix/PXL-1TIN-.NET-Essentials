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

namespace Oef15_5_BoterKaasEieren
{
    public partial class Form1 : Form
    {
        //kruis = speler, O = computer
        private string[,] bord = { { "", "", "" }, { "", "", "" }, { "", "", "" } };

        public Form1()
        {
            InitializeComponent();
        }

        private void TekenKruis(PictureBox pb)
        {
            Graphics area = pb.CreateGraphics();

            area.Clear(Color.White);
            Pen pen = new Pen(Color.Blue);
            area.DrawLine(pen, 5, 5, pb.Width - 5, pb.Height - 5);
            area.DrawLine(pen, pb.Width - 5, 5, 5, pb.Height - 5);
        }

        private void TekenRondje(PictureBox pb)
        {
            Graphics area = pb.CreateGraphics();

            area.Clear(Color.White);
            Pen pen = new Pen(Color.Blue);
            area.DrawEllipse(pen, 5, 5, pb.Width - 10, pb.Height - 10);
        }

        // -1: niemand gewonnen
        // 0 : computer gewonnen
        // 1 : speler gewonnen
        private int CheckWinst()
        {
            int result = CheckKolommen();
            if (result == -1)
            {
                result = CheckRijen();
                if (result == -1)
                {
                    result = CheckDiagonalen();
                }
            }
            return result;
        }

        private int CheckKolommen()
        {
            for (int j = 0; j < bord.GetLength(1); j++)
            {
                string s = "";
                for (int i = 0; i < bord.GetLength(0); i++)
                {
                    s += bord[i, j];
                }
                if (s == "ooo")
                {
                    return 0;
                }
                else if (s == "xxx")
                {
                    return 1;
                }
            }

            return -1;
        }

        private int CheckRijen()
        {
            for (int i = 0; i < bord.GetLength(0); i++)
            {
                string s = "";
                for (int j = 0; j < bord.GetLength(1); j++)
                {
                    s += bord[i, j];
                }
                if (s == "ooo")
                {
                    return 0;
                }
                else if (s == "xxx")
                {
                    return 1;
                }
            }

            return -1;
        }

        private int CheckDiagonalen()
        {
            string s = bord[0, 0] + bord[1, 1] + bord[2, 2];
            if (s == "ooo")
            {
                return 0;
            }
            if (s == "xxx")
            {
                return 1;
            }
            s = bord[0, 2] + bord[1, 1] + bord[2, 0];
            if (s == "ooo")
            {
                return 0;
            }
            if (s == "xxx")
            {
                return 1;
            }
            return -1;
        }

        private void PictureBox_Click(System.Object sender, System.EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            string name = pb.Name;
            int n = Convert.ToInt32(name.Last().ToString());

            int i = n / 3;
            int j = n % 3;

            if (string.IsNullOrEmpty(bord[i, j]))
            {
                bord[i, j] = "x";
                TekenKruis(pb);

                int gewonnen = CheckWinst();
                if (gewonnen == 0)
                {
                    MessageBox.Show("Computer wint");
                    RemoveHandlers();
                    NieuwSpel();
                }
                else if (gewonnen == 1)
                {
                    MessageBox.Show("Speler wint");
                    RemoveHandlers();
                    NieuwSpel();
                }
                else
                {
                    KiesLocatie(ref i, ref j);
                    if (i == -1)
                    {
                        MessageBox.Show("Spel onbeslist");
                        RemoveHandlers();
                        NieuwSpel();
                    }
                    else
                    {
                        bord[i, j] = "o";
                        name = "pictureBox" + Convert.ToString(3 * i + j);
                        pb = (PictureBox)this.Controls.Find(name, true)[0];
                        TekenRondje(pb);
                        gewonnen = CheckWinst();
                        if (gewonnen == 0)
                        {
                            MessageBox.Show("Computer wint");
                            RemoveHandlers();
                            NieuwSpel();
                        }
                        else if (gewonnen == 1)
                        {
                            MessageBox.Show("Speler wint");
                            RemoveHandlers();
                            NieuwSpel();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hier staat al een teken, kies een andere cel");
            }
        }

        private void KiesLocatie(ref int i, ref int j)
        {
            int[] mogelijkheden = new int[9];
            // bevat index met een ""
            int n = -1;
            // index in mogelijkheden op laatste element

            for (int p = 0; p <= 2; p++)
            {
                for (int q = 0; q <= 2; q++)
                {
                    if (string.IsNullOrEmpty(bord[p, q]))
                    {
                        n += 1;
                        mogelijkheden[n] = p * 3 + q;
                    }
                }
            }

            if (n == -1)
            {
                i = -1;
            }
            else
            {
                Random rand = new Random();

                int locatie = rand.Next(0, n - 1);

                i = mogelijkheden[locatie] / 3;
                j = mogelijkheden[locatie] % 3;
            }
        }

        private void NieuwSpel()
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    ((PictureBox)c).CreateGraphics().Clear(Color.White);
                }
            }

            for (int i = 0; i < bord.GetLength(0); i++)
            {
                for (int j = 0; j < bord.GetLength(1); j++)
                {
                    bord[i, j] = "";
                }
            }

            startButton.Enabled = true;
        }

        private void startButton_Click(System.Object sender, System.EventArgs e)
        {
            NieuwSpel();

            InstallHandlers();

            startButton.Enabled = false;
        }

        private void InstallHandlers()
        {
            pictureBox0.Click += PictureBox_Click;
            pictureBox1.Click += PictureBox_Click;
            pictureBox2.Click += PictureBox_Click;
            pictureBox3.Click += PictureBox_Click;
            pictureBox4.Click += PictureBox_Click;
            pictureBox5.Click += PictureBox_Click;
            pictureBox6.Click += PictureBox_Click;
            pictureBox7.Click += PictureBox_Click;
            pictureBox8.Click += PictureBox_Click;
        }

        private void RemoveHandlers()
        {
            pictureBox0.Click -= PictureBox_Click;
            pictureBox1.Click -= PictureBox_Click;
            pictureBox2.Click -= PictureBox_Click;
            pictureBox3.Click -= PictureBox_Click;
            pictureBox4.Click -= PictureBox_Click;
            pictureBox5.Click -= PictureBox_Click;
            pictureBox6.Click -= PictureBox_Click;
            pictureBox7.Click -= PictureBox_Click;
            pictureBox8.Click -= PictureBox_Click;
        }
    }
}
