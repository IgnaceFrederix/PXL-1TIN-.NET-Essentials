using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace T11_2
{
    class ColoredSphere : Sphere
    {
        private Color colors;

        public ColoredSphere(int straal, Colors color)
        {
            straal = Diameter;
            color = color;
        }
    }
}
