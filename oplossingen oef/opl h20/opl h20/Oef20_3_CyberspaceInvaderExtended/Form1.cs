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

namespace Oef20_3_CyberspaceInvaderExtended
{
    public partial class Form1 : Form
    {
        private Graphics paper;
        private User user;
        private Aliens aliens;
        private Lasers lasers;
        private Bombs bombs;
        private Wall wall;
        private Score score;

        public Form1()
        {
            InitializeComponent();

            paper = gamePictureBox.CreateGraphics();
            user = new User(UserImage);
            score = new Score(ScoreLabel);
            aliens = new Aliens(score);
            Alien monster = new Alien(60, 20, AlienImage);
            aliens.Add(monster);
            monster = new Alien(100, 20 + AlienImage.Height, AlienImage);
            aliens.Add(monster);
            monster = new Alien(140, 20 + AlienImage.Height * 2, AlienImage);
            aliens.Add(monster);
            lasers = new Lasers();
            bombs = new Bombs();
            wall = new Wall(100, 50 + AlienImage.Height * 2);
        }

        private void bombTimer_Tick(System.Object sender, System.EventArgs e)
        {
            aliens.Launch(bombs);
        }


        private void animationTimer_Tick(System.Object sender, System.EventArgs e)
        {
            aliens.Move();
            bombs.Move();
            lasers.Move();
            lasers.CheckHit(wall);
            bombs.CheckHit(user);
            aliens.CheckHit(lasers);
            bombs.CheckHit(wall);
            DisplayAll();
            if (aliens.AllDead())
            {
                EndGame("user");
            }
            if (user.Dead)
            {
                EndGame("aliens");
            }
        }

        private void EndGame(string winner)
        {
            AnimationTimer.Enabled = false;
            BombTimer.Enabled = false;
            MessageBox.Show("game over - " + winner + " wins");
            System.Environment.Exit(0);
            AnimationTimer.Enabled = true;
            BombTimer.Enabled = true;
        }


        private void gamePictureBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            const int stepSize = 8;
            user.Move(e.X - stepSize);
            DisplayAll();
        }

        private void DisplayAll()
        {
            paper.Clear(Color.White);
            user.Display(paper);
            aliens.Display(paper);
            lasers.Display(paper);
            bombs.Display(paper);
            wall.Display(paper);
        }

        private void gamePictureBox_Click(System.Object sender, System.EventArgs e)
        {
            // create a new laser at the top middle of the user image
            int initialX = user.X + user.Width / 2;
            int initialY = user.Y - user.Height;
            Laser aLaser = new Laser(initialX, initialY, lasers);
        }
    }
}
