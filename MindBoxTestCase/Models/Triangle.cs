using MindBoxTestCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestCase.Models
{
    public class Triangle : IFigure
    {
        private double[] Sides { get; set; } = new double[3];

        private readonly double delta = 0.00001;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("invalid side length value: no side can be less than / equal to 0");
            }

            if (((a + b) - c <= delta) || ((a + c) - b <= delta) || ((b + c) - a <= delta))
            {
                throw new ArgumentException("invalid side length value");
            }

            Sides[0] = a;
            Sides[1] = b;
            Sides[2] = c;

        }



        public double CalculateArea()
        {
            double halfPerimeter = (Sides[0] + Sides[1] + Sides[2]) / 2;

            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - Sides[0]) * (halfPerimeter - Sides[1]) * (halfPerimeter - Sides[2]));

            return area;
        }

        public bool IsRight()
        {
            Array.Sort(Sides);

            if (Math.Abs(Math.Pow(Sides[2], 2) - Math.Pow(Sides[1], 2) - Math.Pow(Sides[0], 2)) < delta)
            {
                return true;
            }

            return false;
        }
    }
}