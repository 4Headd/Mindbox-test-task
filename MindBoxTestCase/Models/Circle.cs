using MindBoxTestCase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestCase.Models
{
    public class Circle : IFigure
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("invalid radius value: radius cannot be less than / equal to 0");
            }
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
