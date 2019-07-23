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

namespace Oef24_4_VormenMenu
{
    public partial class Form1 : Form
    {
        private List<IDisplayable> group;
        
        public Form1()
        {
            InitializeComponent();
            group = new List<IDisplayable>();
        }

        private void shapesPictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs ev = (MouseEventArgs)e;
            int x = ev.Location.X;
            int y = ev.Location.Y;

            Shape shape = null;

            if (lijnToolStripMenuItem.Checked)
            {
                shape = new Line(x, y, x, y + 50);
            }
            else if (cirkelToolStripMenuItem.Checked)
            {
                shape = new Circle(x, y);
            }
            else
            {
                shape = new Square(x, y);
            }
            group.Add(shape);
            shapesPictureBox.Invalidate();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void shapesPictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (IDisplayable shape in group)
            {
                shape.Display(e.Graphics);
            }
        }

        // onderstaande handlers maken de 3 menuitems wederzijds exclusief (cfr radiobuttons)
        private void lijnToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;

            if (!mi.Checked)
            {
                mi.Checked = true;
            }

            cirkelToolStripMenuItem.Checked = false;
            rechthoekToolStripMenuItem.Checked = false;
        }


        private void cirkelToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;

            if (!mi.Checked)
            {
                mi.Checked = true;
            }

            lijnToolStripMenuItem.Checked = false;
            rechthoekToolStripMenuItem.Checked = false;
        }


        private void rechthoekToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;

            if (!mi.Checked)
            {
                mi.Checked = true;
            }

            cirkelToolStripMenuItem.Checked = false;
            lijnToolStripMenuItem.Checked = false;
        }
    }
}
