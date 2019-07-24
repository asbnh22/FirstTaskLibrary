using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskLibrary
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
            : base()
        {
            this.Radius = radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

