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

namespace Oef11_2_PoolBall
{
    public partial class Form1 : Form
    {
        private PoolBall ball;

        public Form1()
        {
            InitializeComponent();

            ball = new PoolBall(pictureBox1.Width, pictureBox1.Height);
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            ball.MoveDown(Convert.ToInt32(amountTextBox.Text));
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);
            ball.Display(g);
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            ball.MoveUp(Convert.ToInt32(amountTextBox.Text));
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);
            ball.Display(g);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            ball.MoveLeft(Convert.ToInt32(amountTextBox.Text));
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);
            ball.Display(g);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            ball.MoveRight(Convert.ToInt32(amountTextBox.Text));
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);
            ball.Display(g);
        }
    }
}
