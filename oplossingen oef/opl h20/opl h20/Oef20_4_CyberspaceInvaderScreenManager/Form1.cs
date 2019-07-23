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

namespace Oef20_4_CyberspaceInvaderScreenManager
{
    public partial class Game : Form
    {
        private ScreenManager manager;

        public Game()
        {
            InitializeComponent();

            manager = new ScreenManager(gamePictureBox, userPictureBox, alienPictureBox);
        }

        private void bombTimer_Tick(object sender, EventArgs e)
        {
            manager.LaunchBombs();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            manager.MoveAllObjects();
            manager.CheckHits();
            if (manager.TheAlienIsDead())
            {
                EndGame("user");
            }
            else if (manager.TheUserIsDead())
            {
                EndGame("aliens");
            }
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
            manager.CreateLaser();
        }

        private void gamePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            manager.MoveUser(e.X);
        }
    }
}
