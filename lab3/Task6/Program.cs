using System;

namespace Task6
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            QuadraticEquation eq = new QuadraticEquation(1, -5, 6);
            Console.WriteLine($"Початкове рівняння: x^2 - 5x + 6 = 0");
            Console.WriteLine($"Кількість коренів: {eq.AmountOfRoots}");
            Console.WriteLine($"Доступ до полів через властивості читання: x1 = {eq.x1}, x2 = {eq.x2}");
            if (eq.AmountOfRoots > 0)
            {
                Console.WriteLine($"Доступ до полів через індексатор [0]: {eq[0]}");
                Console.WriteLine($"Доступ до полів через індексатор [1]: {eq[1]}");
            }
        }
    }
}
