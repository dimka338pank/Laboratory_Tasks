using System;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SquareSolver solver = new SquareSolver();
            double x1, x2;
            Console.WriteLine("Рівнняня 1 : x^2 - 3x + 2 = 0");
            int count = solver.SolverWithOut(1, -3, 2, out x1, out x2);
            if( count == -1) Console.WriteLine("Коренів безліч");
            if (count > 0)
            {
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"Кількість коренів: {count}");
            }
            if (count == 2)
            {
                Console.WriteLine($"x2 = {x2}");
                Console.WriteLine($"Кількість коренів: {count}");
            }


            Console.WriteLine("\nРівнняня 2 : x^2 - 5x + 6 = 0");
            StructResults results2 = solver.SolveWithStruct(1, -5, 6);
            Console.WriteLine($"Кількість коренів: {results2.AmountOfRoots}\nx1: {results2.x1}\nx2: {results2.x2}");


            Console.WriteLine("\nРівнняня 3 : x^2 - 9x + 20 = 0");
            (int count, double x1, double x2) result3 = solver.SolveWithTuple(1, -9, 20);
            Console.WriteLine($"Кількість коренів: {result3.count}");
            Console.WriteLine($"Перший корінь: {result3.x1}");
            Console.WriteLine($"Другий корінь: {result3.x2}");
        }

        
    }
}
