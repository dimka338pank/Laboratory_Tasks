using System;
using static Task2.InterfaceClass;

namespace Task2
{
    public class ISolver
    {
        public void Solve(IFunction func, double start, double end, double step)
        {
            Console.WriteLine($"Пошук коренів на [{start}, {end}] з кроком {step}: ");
            bool found = false;
            for (double x = start; x < end; x += step)
            {
                if (func.IFindRoot(x) * func.IFindRoot(x + step) <= 0)
                {
                    double root = (x + x + step) / 2;
                    Console.WriteLine($"Знайдено корінь: {root}");
                    found = true;
                }
            }

            if (!found) Console.WriteLine("Коренів не знайдено.");
        }
    }
}
