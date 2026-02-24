using System;


namespace Task2
{
    internal class MyFunction : IFunction
    {
        public double Calculate(double x)
        {
            return x*x - 9;
        }
    }
}
