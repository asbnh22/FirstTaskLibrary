using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

using FirstTaskLibrary;

namespace FirstTaskLibraryTests
{
    [TestClass]
    public class CalculateFiguresTests
    {
        [TestMethod]
        public void Total_Perimeter_Test_Method()
        {

            List<Figure> figures = new List<Figure>()
            {
                new Rectangle(width: 3, height: 5), // P = 2 * (a + b) 
                new Circle(radius: 7/Math.PI), // P = 2 * PI * r
                new Square(side: 11), // P = 2 * (a + a)
                new Triangle(sideA: 3, sideB: 4, sideC: 5), // P = a + b + c
                new Trapezium(sideA: 13, sideB: 5,sideC: 13, sideD: 25, height: 12) // P = a + b + c + d
            };
            double expected = 142;

            double actual = figures.Sum(item => item.Perimeter());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Total_Area_Test_Method()
        {
            List<Figure> figures = new List<Figure>()
            {
                new Rectangle(width: 3, height: 5), // S = a * b
                new Circle(radius: 7/(Math.Sqrt(Math.PI))), // S = PI * r^2
                new Square(side: 11), // S = a * a
                new Triangle(sideA: 3, sideB: 4, sideC: 5), //S = sqrt(p * (p - a) * (p - b) * (p - c)), where p = (a + b + c) / 2
                new Trapezium(sideA: 13, sideB: 5,sideC: 13, sideD: 25, height: 12) //S = h * (b + d) / 2 
            };

            double expected = 371;

            double actual = figures.Sum(item => item.Area());
            Assert.AreEqual(expected, actual);
        }
    }
}
