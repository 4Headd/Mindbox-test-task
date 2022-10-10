using MindBoxTestCase.Models;

namespace MindBoxUnitTests
{
    [TestClass]
    public class TriangleTest
    {
        private readonly double delta = 0.00001;

        [TestMethod]
        public void TestTriangleExistence()
        {
            // wrong triangle
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 3, 5));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 3, 5));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 3, 5));

            // triangle
            Triangle triangle1 = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(6, 3, 6);
            Triangle triangle3 = new Triangle(5, 5, 5);
        }

        [TestMethod]
        public void TestCalculateArea()
        {
            Triangle triangle1 = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle1.CalculateArea(), delta);

            Triangle triangle2 = new Triangle(3.4, 4.2, 5.3);
            Assert.AreEqual(7.134605, triangle2.CalculateArea(), delta);

            Triangle triangle3 = new Triangle(6, 3, 6);
            Assert.AreEqual(8.714213, triangle3.CalculateArea(), delta);
        }

        [TestMethod]
        public void TestIsRight()
        {
            // triangle is right
            Triangle triangle1 = new Triangle(24, 26, 10);
            Assert.IsTrue(triangle1.IsRight());

            // triangle is not right
            Triangle triangle2 = new Triangle(6, 3, 6);
            Assert.IsFalse(triangle2.IsRight());
        }
    }
}