using System;

namespace Task2
{
    internal abstract class AbstractClass
    {
        public abstract double Function(double x);

        public void Solve(double start, double end, double step)
        {
            Console.WriteLine($"Пошук коренів на інтервалі [{start}, {end}] з кроком {step}:");
            bool found = false;
            for (double x = start; x < end; x += step)
            {
                if (Function(x) * Function(x + step) <= 0)
                {
                    double root = (x + (x + step)) / 2;
                    Console.WriteLine($"Знайдено корінь (приблизно): {root}");
                    found = true;
                }
            }

            if (!found) Console.WriteLine("Коренів не знайдено.");
        }
    }
}
