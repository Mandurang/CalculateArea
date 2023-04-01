using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Circle : IShape
    {
        private double CircleRadius { get { return CircleRadius; } set { if (value <= 0) throw new ArgumentException("Length can't be negative or equal 0"); } }


        public Circle(double circleRadius)
        {
            CircleRadius = circleRadius;
        }


        public double CalculateAreaFigure()
        {
            return Math.PI * (CircleRadius * CircleRadius);
        }


        public bool IsValidArea()
        {
            if (CalculateAreaFigure() <= 0)
            {
                throw new ArgumentException("Area can't be negative or equal 0");
            }

            return true;
        }
    }
}
