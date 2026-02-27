using System;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Абстрактні класи");
            MyEquation equation = new MyEquation();
            try
            {
                Console.Write("Введіть початок інтервалу: ");
                double start = double.Parse(Console.ReadLine());
                Console.Write("Введіть кінець інтервалу: ");
                double end = double.Parse(Console.ReadLine());
                Console.Write("Введіть крок: ");
                double step = double.Parse(Console.ReadLine());
                equation.FindRoot(start, end, step);
            }
            catch (Exception)
            {
                Console.WriteLine("Помилка вводу! Вводьте лише числа(якщо десятковий дріб, то через кому)");
            }
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Інтерфейс");

            QuadraticFunction function = new QuadraticFunction();
            ISolver solver = new ISolver();
            try
            {
                Console.Write("Введіть початок інтервалу: ");
                double start = double.Parse(Console.ReadLine());
                Console.Write("Введіть кінець інтервалу: ");
                double end = double.Parse(Console.ReadLine());
                Console.Write("Введіть крок: ");
                double step = double.Parse(Console.ReadLine());
                solver.Solve(function ,start, end, step);
            }
            catch (Exception)
            {
                Console.WriteLine("Помилка вводу! Вводьте лише числа(якщо десятковий дріб, то через кому)");
            }
        }
    }
}
