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

namespace Oef6_5_InhoudZwembad
{
    public partial class Form1 : Form
    {
        private Graphics paper;
        private Pen pen;
        private double gemiddeldeDiepte, inhoud;
        
        public Form1()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            paper = zwembadPictureBox.CreateGraphics();
            pen = new Pen(Color.Black);
            diepLabel.Text = String.Format("Diepte {0} m", -1 * diepTrackBar.Value / 10);
            ondiepLabel.Text = String.Format("Diepte {0} m", -1 * ondiepTrackBar.Value / 10);
        }

        private void diepTrackBar_Scroll(object sender, EventArgs e)
        {
            diepLabel.Text = String.Format("Diepte {0} m", -1 * diepTrackBar.Value / 10);
            DwarsdoorsnedeInhoud(paper);
        }

        private void ondiepTrackBar_Scroll(object sender, EventArgs e)
        {
            ondiepLabel.Text = String.Format("Diepte {0} m", -1 * ondiepTrackBar.Value / 10);
            DwarsdoorsnedeInhoud(paper);
        }

        private void DwarsdoorsnedeInhoud(Graphics paper)
        {
            paper.Clear(Color.LightGray);

            paper.DrawLine(pen, 10, 10, 210, 10);
            paper.DrawLine(pen, 10, 10, 10, -1 * diepTrackBar.Value + 10);
            paper.DrawLine(pen, 210, 10, 210, -1 * ondiepTrackBar.Value + 10);
            paper.DrawLine(pen, 10, -1 * diepTrackBar.Value + 10, 210, -1 * ondiepTrackBar.Value + 10);
            gemiddeldeDiepte = -1 * (diepTrackBar.Value + ondiepTrackBar.Value) / 20;
            inhoud = gemiddeldeDiepte * 20 * 5;
            inhoudLabel.Text = String.Format("{0} m³", inhoud);
        }
    }
}
