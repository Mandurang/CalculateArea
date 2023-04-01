using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Triangle : IShape
    {
        private double CatetA { get { return CatetA; } set { if (value <= 0) throw new ArgumentException("Length can't be negative or equal 0"); } }

        private double CatetB { get { return CatetB; } set { if (value <= 0) throw new ArgumentException("Length can't be negative or equal 0"); } }

        private double CatetC { get { return CatetC; } set { if (value <= 0) throw new ArgumentException("Length can't be negative or equal 0"); } }

        public Triangle(double catetA, double catetB, double catetC)
        {
            CatetA = catetA;
            CatetB = catetB;
            CatetC = catetC;
        }

        public double CalculateAreaFigure()
        {
            double prm = (CatetA + CatetB + CatetC) / 2;

            return Math.Sqrt(prm * (prm - CatetA) * (prm - CatetB) * (prm - CatetC));
        }

        public bool IsRightTriangle()
        {
            double max = new[] { CatetA, CatetB, CatetC }.Max();
            double maxPow = Math.Pow(max, 2);

            if (maxPow == CatetA * CatetA + CatetB * CatetB + CatetC * CatetC - maxPow)
            {
                return true;
            }

            return false;
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
