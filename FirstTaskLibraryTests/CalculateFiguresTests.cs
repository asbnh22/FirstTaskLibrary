using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
                new Rectangle(3,5), // P = 2 * (a + b) 
                new Circle(7/Math.PI), // P = 2 * PI * r
                new Square(11), // P = 2 * (a + a)
                new Triangle(3,4,5), // P = a + b + c
                new Trapezium(13,5,13,25,12) // P = a + b + c + d
            };

            double expected = 142;

            CalculateFigures cf = new CalculateFigures();
            double actual = cf.TotalPerimeter(figures);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Total_Area_Test_Method()
        {
            List<Figure> figures = new List<Figure>()
            {
                new Rectangle(3,5), // S = a * b
                new Circle(7/(Math.Sqrt(Math.PI))), // S = PI * r^2
                new Square(11), // S = a * a
                new Triangle(3,4,5), //S = sqrt(p * (p - a) * (p - b) * (p - c)), where p = (a + b + c) / 2
                new Trapezium(13,5,13,25,12) //S = h * (b + d) / 2 
            };

            double expected = 371;

            CalculateFigures cf = new CalculateFigures();
            double actual = (float)cf.TotalArea(figures);

            Assert.AreEqual(expected, actual);
        }
    }
}
