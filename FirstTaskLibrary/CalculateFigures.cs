using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FirstTaskLibrary
{
    public class CalculateFigures
    {
        public double TotalPerimeter(List<Figure> figures)
        {
           return figures.Sum(item => item.Perimeter());
        }

        public double TotalArea(List<Figure> figures)
        {
           return figures.Sum(item => item.Area());

        }
    }
}
