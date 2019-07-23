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

namespace Cyberspace_Invader
{
    public partial class Game : Form
    {
        private Graphics paper;
        private User user;
        private Alien alien;
        private Lasers lasers;
        private Bombs bombs;

        public Game()
        {
            InitializeComponent();

            paper = gamePictureBox.CreateGraphics();
            user = new User(userPictureBox);
            alien = new Alien(alienPictureBox);
            lasers = new Lasers();
            bombs = new Bombs();
        }

        private void bombTimer_Tick(object sender, EventArgs e)
        {
            alien.Launch(bombs);
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            alien.Move();
            bombs.Move();
            lasers.Move();
            bombs.CheckHit(user);
            alien.CheckHit(lasers);

            DrawAll();

            if (alien.Dead)
            {
                EndGame("user");
            }
            if (user.Dead)
            {
                EndGame("alien");
            }

        }

        private void DrawAll()
        {
            paper.Clear(Color.White);
            user.Display(paper);
            alien.Display(paper);
            lasers.Display(paper);
            bombs.Display(paper);
        }

        private void EndGame(string winner)
        {
            animationTimer.Enabled = false;
            bombTimer.Enabled = false;
            MessageBox.Show("game over - " + winner + " wins");
            Environment.Exit(0);
        }

        private void gamePictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            int x = user.X + user.Width / 2;
            int y = user.Y - user.Height;
            Laser laser = new Laser(x, y, lasers);
        }

        private void gamePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            int stepSize = 8;
            user.Move(e.X - stepSize);
            DrawAll();
        }
    }
}
