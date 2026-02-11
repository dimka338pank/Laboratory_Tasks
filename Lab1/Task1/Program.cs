using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double x, n, a, y1, y2, y3, q;
            Console.WriteLine("Введіть значення x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть значення n:");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть значення a:");
            a = Convert.ToDouble(Console.ReadLine());

            y1 = Math.Abs(Math.Cos(x) + Math.Sin(x));
            Console.WriteLine($"y1 = {y1:F10}");
            y2 = Math.Cos(Math.Pow(x, 3));
            Console.WriteLine($"y2 = {y2:F10}");
            y3 = Math.Exp(Math.Tan(x) / (n + 1)) + Math.Abs((a + 1) / (x - 1));
            Console.WriteLine($"y3 = {y3:F10}");

        }
    }
}