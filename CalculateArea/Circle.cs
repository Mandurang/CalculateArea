using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Circle : IShape
    {
        private double CircleRadius { get; set; }

        public Circle(double circleRadius)
        {
            CircleRadius = circleRadius;
        }

        public double CalculateAreaFigure()
        {
            IsValidParam();
            return Math.PI * (CircleRadius * CircleRadius);
        }

        public void IsValidParam()
        {
            if (CircleRadius <= 0)
            {
                throw new ArgumentException("Area can't be negative or equal 0");

                //Console.WriteLine("Area can't be negative or equal 0"); - we also can add/push exception dependent our realization
            }
        }
    }
}
