using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace CommandLineDrawing
{
    public abstract class Shape 
    {
       
        private void TekenVorm(int x, int y, int breedte, int hoogte, Color kleur)
        {
            xpos = x;
            ypos = y;
            breedtevar = breedte;
            hoogtevar = hoogte;
            kleurvar = kleur;

        }
        public int xpos { get; set; }
        public int ypos { get; set; }
        public int breedtevar { get; set; }
        public int hoogtevar { get; set; }
        public Color kleurvar { get; set; }

  
    }
}