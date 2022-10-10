using MindBoxTestCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxUnitTests
{
    [TestClass]
    public class CircleTest
    {
        private readonly double delta = 0.00001;

        [TestMethod]
        public void TestCircleExistence()
        {
            // wrong circle
            Assert.ThrowsException<ArgumentException>(() => new Circle(0));
            Assert.ThrowsException<ArgumentException>(() => new Circle(-1));

            // circle
            Circle circle1 = new Circle(0.1);
            Circle circle2 = new Circle(21);
        }

        [TestMethod]
        public void TestCalculateArea()
        {
            Circle circle1 = new Circle(0.1);
            Assert.AreEqual(0.031415, circle1.CalculateArea(), delta);

            Circle circle2 = new Circle(21);
            Assert.AreEqual(1385.44236, circle2.CalculateArea(), delta);

        }
    }
}
