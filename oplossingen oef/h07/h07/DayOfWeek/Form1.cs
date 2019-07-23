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

namespace DayOfWeek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string dayOfWeek1(int dayNumber)
        {
            string dayName = "";

            if (dayNumber == 1)
            {
                dayName = "Monday";
            }
            else if (dayNumber == 2)
            {
                dayName = "Tuesday";
            }
            else if (dayNumber == 3)
            {
                dayName = "Wednesday";
            }
            else if (dayNumber == 4)
            {
                dayName = "Thursday";
            }
            else if (dayNumber == 5)
            {
                dayName = "Friday";
            }
            else if (dayNumber == 6)
            {
                dayName = "Saturday";
            }
            else if (dayNumber == 7)
            {
                dayName = "Sunday";
            }
            
            return dayName;
        }

        private string dayOfWeek2(int dayNumber)
        {
            string dayName = "";

            switch (dayNumber)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
            }

            return dayName;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            dayLabel.Text = dayOfWeek2(trackBar1.Value);
        }
    }
}
