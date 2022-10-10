using MindBoxTestCase.Interfaces;
using MindBoxTestCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestCase.Services
{
    public static class Figure
    {
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);

            return triangle.CalculateArea();
        }

        public static double CalculateCircleArea(double radius)
        {
            Circle circle = new Circle(radius);

            return circle.CalculateArea();
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);

            return triangle.IsRight();
        }

        public static double CalculateArea(IFigure figure)
        {
            ArgumentNullException.ThrowIfNull(figure);

            return figure.CalculateArea();
        }
    }
}
