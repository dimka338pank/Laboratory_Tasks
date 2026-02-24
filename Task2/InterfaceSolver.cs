using System;

namespace Task2
{
    internal class InterfaceSolver
    {
        public void Solve(IFunction func, double start, double end, double step)
        {
            Console.WriteLine($"Пошук на [{start}, {end}]:");
            for (double x = start; x < end; x += step)
            {
                if (func.Calculate(x) * func.Calculate(x + step) <= 0)
                {
                    double root = (x + (x + step)) / 2;
                    Console.WriteLine($"Корінь: {root}");
                }
            }
        }
    }
}
