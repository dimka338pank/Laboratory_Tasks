using System;
namespace Task6
{
    public class QuadraticEquation
    {
        public double x1 { get; private set; }
        public double x2 { get; private set; }
        public int AmountOfRoots { get; private set; }

        public QuadraticEquation(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            if (d < 0)
                AmountOfRoots = 0;
            else if (d == 0)
            {
                AmountOfRoots = 1;
                x1 = -b / (2 * a);
                x2 = x1;
            }
            else
            {
                AmountOfRoots = 2;
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }
        }
        public double this[int pepepe]
        {
            get
            {
                if (pepepe == 0) return x1;
                if (pepepe == 1) return x2;
                throw new IndexOutOfRangeException("Індекс має бути 0 або 1.");
            }
        }
    }
}
