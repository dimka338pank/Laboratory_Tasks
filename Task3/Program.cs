using System;

namespace Task3
{
    public class Program
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Complex num1 = new Complex { Real = 4, Imaginary = 2 };
            Complex num2 = new Complex { Real = 1, Imaginary = -3 };

            Complex sum = num1 + num2;
            Complex diff = num1 - num2;
            Complex mult = num1 * num2;
            Complex div = num1 / num2;

            Console.WriteLine($"Число 1: {num1}");
            Console.WriteLine($"Число 2: {num2}\n");
            Console.WriteLine($"Сума: {sum}");
            Console.WriteLine($"Різниця: {diff}");
            Console.WriteLine($"Множення: {mult}");
            Console.WriteLine($"Ділення: {div}");
        }
    }
}
