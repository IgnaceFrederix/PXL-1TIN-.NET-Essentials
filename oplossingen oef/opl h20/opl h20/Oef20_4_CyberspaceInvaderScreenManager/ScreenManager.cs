//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Oef20_4_CyberspaceInvaderScreenManager
{
    public class ScreenManager
    {
        private Graphics paper;
        private User theUser;
        private Alien theAlien;
        private Lasers theLasers;
        private Bombs theBombs;

        const int stepSize = 8;
        public ScreenManager(PictureBox pb, PictureBox UserImage, PictureBox AlienImage)
        {
            paper = pb.CreateGraphics();
            theUser = new User(UserImage);
            theAlien = new Alien(AlienImage);
            theLasers = new Lasers();
            theBombs = new Bombs();
        }

        public void LaunchBombs()
        {
            theAlien.Launch(theBombs);
        }

        public void MoveAllObjects()
        {
            theAlien.Move();
            theBombs.Move();
            theLasers.Move();
        }

        public void CheckHits()
        {
            theBombs.CheckHit(theUser);
            theAlien.CheckHit(theLasers);
            DrawAll();
        }

        public bool TheAlienIsDead()
        {
            return theAlien.Dead;
        }

        public bool TheUserIsDead()
        {
            return theUser.Dead;
        }

        public void MoveUser(int x)
        {
            theUser.Move(x - stepSize);
            DrawAll();
        }

        public void CreateLaser()
        {
            int initialX = theUser.X + theUser.Width / 2;
            int initialY = theUser.Y - theUser.Height;
            Laser aLaser = new Laser(initialX, initialY, theLasers);
        }

        private void DrawAll()
        {
            paper.Clear(Color.White);
            theUser.Display(paper);
            theAlien.Display(paper);
            theLasers.Display(paper);
            theBombs.Display(paper);
        }
    }
}
