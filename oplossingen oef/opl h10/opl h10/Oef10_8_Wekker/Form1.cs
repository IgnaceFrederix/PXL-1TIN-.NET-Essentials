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

namespace Oef10_8_Wekker
{
    /// <summary>
    /// Hoofdstuk 10, Oefening 8: Wekker
    /// </summary>
    /// <remarks>
    /// In deze oplossing zijn een aantal <c>Console.WriteLine</c> statements
    /// opgenomen. Dit helpt bij het debuggen van de applicatie. Merk op dat het
    /// gebruik van de debugger bij dit soort applicaties (Timers) haast
    /// onmogelijk is.</b>
    /// </remarks>
    public partial class Form1 : Form
    {
        private Wekker wekker;
        private Color color1;
        private Color color2;
        
        public Form1()
        {
            InitializeComponent();
            wekker = new Wekker();
            clockTimer.Start();
            color1 = this.BackColor;
            color2 = Color.Tomato;
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = wekker.CurrentTime;
            if (wekker.IsAlarmPassed())
            {
                Console.WriteLine("Alarm passed");
                alarmTimer.Start();
            }
            else
            {
                Console.WriteLine("Alarm NOT passed");
            }
            if (wekker.ShouldStopBeeping())
            {
                Console.WriteLine("ShouldStopBeeping");
                alarmTimer.Stop();
                wekker.Reset();
                alarmTextBox.Text = "";
                this.BackColor = color1;
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            wekker.AlarmTime = alarmTextBox.Text;
        }

        private void alarmTimer_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == color1)
            {
                this.BackColor = color2;
            }
            else
            {
                this.BackColor = color1;
            }
        }
    }
}
