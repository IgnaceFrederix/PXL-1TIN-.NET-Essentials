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

namespace Animals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal anim1, anim2, anim3;
            anim1 = new Animal("Woefie");
            anim2 = new Dog("Pluto");
            anim3 = new SmallDog("Fifike");

            PrintAnimal(anim1);
            PrintAnimal(anim2);
            PrintAnimal(anim3);
        }

        private void PrintAnimal(Animal anim)
        {
            String line = String.Format("animal ({0}) sounds as: {1}",
                                        anim.Name, anim.Sound());
            MessageBox.Show(line);
        }
    }
}
