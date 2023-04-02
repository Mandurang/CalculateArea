using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Triangle : IShape
    {
        private double CatetA { get; set; } 
        private double CatetB { get; set; }
        private double CatetC { get; set; }

        public Triangle(double catetA, double catetB, double catetC)
        {
            CatetA = catetA;
            CatetB = catetB;
            CatetC = catetC;
        }

        public double CalculateAreaFigure()
        {
            IsValidParam();
            double prm = (CatetA + CatetB + CatetC) / 2;

            return Math.Sqrt(prm * (prm - CatetA) * (prm - CatetB) * (prm - CatetC));
        }

        public bool IsRightTriangle()
        {
            IsValidParam();
            double max = new[] { CatetA, CatetB, CatetC }.Max();
            double maxPow = Math.Pow(max, 2);

            if (maxPow == CatetA * CatetA + CatetB * CatetB + CatetC * CatetC - maxPow)
            {
                return true;
            }

            return false;
        }

        public void IsValidParam()
        {
            if(CatetA <= 0 || CatetB <= 0 || CatetC <= 0 )
            {
                throw new ArgumentException("Area can't be negative or equal 0");

                //Console.WriteLine("Area can't be negative or equal 0"); -we also can add / push exception dependent our realization
            }
        }
    }
}
