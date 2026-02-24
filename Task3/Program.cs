using System;
using System.Collections.Generic;
using System.IO;

namespace Task3
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string text = "Шоколад Milka — це всесвітньо відомий швейцарський бренд \n(зараз під управлінням Mondelēz International),\n який виробляє ніжний молочний шоколад з додаванням справжнього альпійського молока. \nЙого впізнають за фіолетовою упаковкою, кремовою текстурою,\n що тане в роті, та солодким вершковим смаком";
            try
            {
                Console.WriteLine("Введіть довжину рядка(цілі числа):");
                int line_lenght = int.Parse(Console.ReadLine());
                string startPath = "source.txt";
                string endPath = "result.txt";
                if (!File.Exists(startPath))
                {
                    File.WriteAllLines(startPath, new[] {text, "оні це прибульці", "ура", "я куплю шоколадку", "зал", "<3"});
                    Console.WriteLine($"Файл {startPath} не знайдено, тому він був створений і в нього був записаний текст");
                }
                string [] all_lines = File.ReadAllLines(startPath);
                List<string> filteredLines = new List<string>();

                foreach (string line in all_lines)
                {
                    Console.WriteLine($"Рядок: {line} Довжина: {line.Length}");
                    if (line.Length <= line_lenght)
                    {
                        filteredLines.Add(line);
                    }
                }

                File.WriteAllLines(endPath, filteredLines);
                Console.WriteLine($"У файл {endPath} збережено рядків: {filteredLines.Count}");
                string[] finalLines = File.ReadAllLines(endPath);

                Console.WriteLine("Вміст кінцевого файлу: ");
                foreach (string line in finalLines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виникла помилка: {ex.Message}");
            }
        }
    }
}
