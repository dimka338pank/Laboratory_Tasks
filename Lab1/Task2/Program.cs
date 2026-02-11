using System;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Завдання 1 6.  Ввести три окремих символи. Вивести на екран числовий код кожного символу.
            char a, b, c;
            Console.WriteLine("Введіть перший символ :");
            a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введіть другий символ :");
            b = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введіть третій символ :");
            c = Convert.ToChar(Console.ReadLine());
            Console.Write("Числовий код 1-го символу: ");
            Console.WriteLine(a + 0);
            int code_b = (int)b;
            Console.WriteLine("Числовий код 2-го символу: " + code_b);
            int code_c = (int)c;
            Console.Write("Числовий код 3-го символу: " + code_c);

            //Завдання 2 6.  Ввести три окремих рядки тексту. Вивести на екран всі рядки у верхньому регістрі.

            string A, B, C;
            Console.WriteLine("\nВведіть 1-й рядок: ");
            A = Console.ReadLine();
            Console.WriteLine("Введіть 2-й рядок: ");
            B = Console.ReadLine();
            Console.WriteLine("Введіть 3-й рядок: ");
            C = Console.ReadLine();
            Console.Write(A.ToUpper() + ". " + B.ToUpper() + ". " + C.ToUpper() + ".");
        }
    }
}