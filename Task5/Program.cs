using System;

namespace Task5
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть координату X(ціле число): ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть координату Y(ціле число): ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть координату Z(ціле число): ");
            int z = Convert.ToInt32(Console.ReadLine());

            Point3D point = new Point3D ( x, y, z );
            double distance = point.CalculateDistanceToZero();
            Console.WriteLine($"Точка: ({x}, {y}, {z})");
            Console.WriteLine($"Відстань від точки до початку координат: {distance}");
        }
    }
}
