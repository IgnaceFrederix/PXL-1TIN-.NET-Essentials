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

namespace Oef11_7_Beep_Knipper_Wekker
{
    public partial class Form1 : Form
    {
        private Wekker wekker;
       
        public Form1()
        {
            InitializeComponent();
            wekker = new KnipperWekker(this);
            clockTimer.Start();
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
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            wekker.AlarmTime = alarmTextBox.Text;
        }

        private void alarmTimer_Tick(object sender, EventArgs e)
        {
            wekker.Go();
        }

        private void beepRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // reset de wekker, want we veranderen het type
            wekker.Reset();
            alarmTextBox.Text = "";
            wekker=new BeepWekker();
        }

        private void knipperRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            wekker.Reset();
            alarmTextBox.Text = "";
            wekker = new KnipperWekker(this);
        }
    }
}
