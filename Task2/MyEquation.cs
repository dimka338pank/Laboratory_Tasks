using System;

namespace Task2
{
    internal class MyEquation : AbstractClass
    {
        public override double Function(double x)
        {
            return x*x - 3*x - 4;
        }
    }
}
