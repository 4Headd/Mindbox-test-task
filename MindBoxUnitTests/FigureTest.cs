using MindBoxTestCase.Interfaces;
using MindBoxTestCase.Models;
using MindBoxTestCase.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxUnitTests
{
    [TestClass]
    public class FigureTest
    {
        private readonly double delta = 0.00001;

        [TestMethod]
        public void TestCalculateTriangleArea()
        {
            Assert.AreEqual(8.714213, Figure.CalculateTriangleArea(6, 3, 6), delta);

            Assert.AreEqual(7.134605, Figure.CalculateTriangleArea(3.4, 4.2, 5.3), delta);

            Assert.AreEqual(6, Figure.CalculateTriangleArea(3, 4, 5), delta);
        }

        [TestMethod]
        public void TestCalculateCircleArea()
        {
            Assert.AreEqual(0.031415, Figure.CalculateCircleArea(0.1), delta);

            Assert.AreEqual(1385.44236, Figure.CalculateCircleArea(21), delta);
        }

        [TestMethod]
        public void TestIsRight()
        {
            Assert.IsTrue(Figure.IsRightTriangle(24, 26, 10));

            Assert.IsFalse(Figure.IsRightTriangle(6, 3, 6));
        }

        [TestMethod]
        public void TestCalculateArea()
        {
            IFigure figure = new Circle(3);

            Assert.AreEqual(28.274333, Figure.CalculateArea(figure), delta);
        }
    }
}
