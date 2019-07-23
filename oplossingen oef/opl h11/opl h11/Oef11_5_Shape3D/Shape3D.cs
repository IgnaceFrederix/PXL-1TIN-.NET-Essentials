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

namespace Oef11_5_Shape3D
{
    public abstract class Shape3D
    {
        private int x;
        private int y;
        private int z;
        
        public Shape3D()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }
        
        /// <summary>
        /// verplaats naar nieuw punt tov oorsprong
        /// </summary>
        /// <param name="newX">nieuwe X coord</param>
        /// <param name="newY">nieuwe Y coord</param>
        /// <param name="newZ">nieuwe Z coord</param>
        /// <remarks></remarks>
        public void MoveTo(int newX, int newY, int newZ)
        {
            x = newX;
            y = newY;
            z = newZ;
        }

        /// <summary>
        /// Roteer rond de X-as
        /// </summary>
        /// <param name="degree">aantal graden in tegenwijzerzin</param>
        /// <remarks></remarks>
        public abstract void RotateX(int degree);


        /// <summary>
        /// Roteer rond de Y-as
        /// </summary>
        /// <param name="degree">aantal graden in tegenwijzerzin</param>
        /// <remarks></remarks>
        public abstract void RotateY(int degree);


        /// <summary>
        /// Roteer rond de Z-as
        /// </summary>
        /// <param name="degree">aantal graden in tegenwijzerzin</param>
        /// <remarks></remarks>
        public abstract void RotateZ(int degree);

        public abstract void Display(Graphics area);
    }
}
