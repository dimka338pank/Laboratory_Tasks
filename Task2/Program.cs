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
            MyEquation eq = new MyEquation();
            try
            {
                Console.Write("Введіть початок інтервалу: ");
                double start = double.Parse(Console.ReadLine());
                Console.Write("Введіть кінець інтервалу: ");
                double end = double.Parse(Console.ReadLine());
                Console.Write("Введіть крок: ");
                double step = double.Parse(Console.ReadLine());
                eq.Solve(start, end, step);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка вводу! Вводьте лише числа(якщо десятковий дріб, то через кому)" + ex.Message);
            }

            Console.WriteLine("Інтерфейс");
            InterfaceSolver solver = new InterfaceSolver();
            MyFunction myFunc = new MyFunction();
            try
            {
                Console.Write("Введіть початок інтервалу: ");
                double start = double.Parse(Console.ReadLine());
                Console.Write("Введіть кінець інтервалу: ");
                double end = double.Parse(Console.ReadLine());
                Console.Write("Введіть крок: ");
                double step = double.Parse(Console.ReadLine());
                solver.Solve(myFunc, start, end, step);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка вводу! Вводьте лише числа(якщо десятковий дріб, то через кому)" + ex.Message);
            }
        }
    }
}
