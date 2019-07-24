using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskLibrary
{
    public class Trapezium : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }
        public double Height { get; set; }

        public Trapezium(double sideA, double sideB, double sideC, double sideD, double height)
            : base()
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            this.SideD = sideD;
            this.Height = height;
        }

        public override double Area()
        {
            return 0.5 * (SideB + SideD) * Height;
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC + SideD;
        }
    }
}

