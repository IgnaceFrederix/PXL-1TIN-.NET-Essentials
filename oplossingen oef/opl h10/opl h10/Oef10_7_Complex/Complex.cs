//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef10_7_Complex
{
    public class Complex
    {
        private double real;
        private double img;

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.img = imaginary;
        }

        public double Real
        {
            get { return real; }
            set { real = value; }
        }

        public double Imaginary
        {
            get { return img; }
            set { img = value; }
        }
        
        public Complex Sum(Complex other)
        {
            return new Complex(real + other.Real,
                               img + other.Imaginary);
        }

        public Complex Product(Complex other)
        {
            return new Complex(real * other.Real - img * other.Imaginary,
                               real * other.Imaginary + other.Real * img);
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", real, img);
        }
    }
}
