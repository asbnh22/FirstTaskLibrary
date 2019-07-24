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
                new Circle(7/Math.PI) // P = 2 * PI * r
            };

            double expected = 30;

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
                new Circle(7/(Math.Sqrt(Math.PI))) // S = PI * r^2
            };

            double expected = 64;

            CalculateFigures cf = new CalculateFigures();
            double actual = (float)cf.TotalArea(figures);


            Assert.AreEqual(expected, actual);
        }
    }
}
