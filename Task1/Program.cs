using System;
using System.Collections.Generic;
using System.IO;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Member> team = new List<Member>();
            try
            {
                if (File.Exists("Members.txt"))
                    LoadFromFile(team);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка при автозавантаженні: " + ex.Message);
            }

            bool running = true;
            while (running)
            {
                Console.WriteLine("Виберіть опцію:");
                Console.WriteLine("1. Показати список");
                Console.WriteLine("2. Сортувати за розміром");
                Console.WriteLine("3. Пошук за останньою літерою");
                Console.WriteLine("4. Додати учасника");
                Console.WriteLine("5. Видалити учасника");
                Console.WriteLine("6. Зберегти у файл");
                Console.WriteLine("7. Завантажити з файлу");
                Console.WriteLine("0. Завершити роботу");
                Console.Write("Введіть опцію: ");

                string choice = Console.ReadLine();

                try
                {
                    if (string.IsNullOrEmpty(choice) || choice.Length > 1 || !char.IsDigit(choice[0]))
                        throw new Exception("Потрібно ввести лише одну цифру від 0 до 7.");
                    switch (choice)
                    {
                        case "1":
                            PrintList(team);
                            break;
                        case "2":
                            SortSurnames(team);
                            PrintList(team);
                            break;
                        case "3":
                            Console.Write("Введіть літеру: ");
                            char letter = Convert.ToChar(Console.ReadLine());
                            SearchByLastLetter(team, letter);
                            break;
                        case "4":
                            AddNewMember(team);
                            break;
                        case "5":
                            DeleteMember(team);
                            break;
                        case "6":
                            SaveToFile(team);
                            break;
                        case "7":
                            LoadFromFile(team);
                            break;
                        case "0":
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Неправильний вибір");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
            }
            void PrintList(List<Member> list)
            {
                for (int i = 0; i < list.Count; i++)
                    Console.WriteLine((i + 1) + ". " + list[i].ToString());
            }

            void SortSurnames(List<Member> list)
            {
                list.Sort((a, b) => b.surname.Length.CompareTo(a.surname.Length));
            }

            void SearchByLastLetter(List<Member> list, char letter)
            {
                string user_input = letter.ToString().ToLower();

                List<Member> similarities = list.FindAll(m => m.surname.ToLower().EndsWith(user_input));
                Console.WriteLine($"Результати пошуку за останньою літерою '{letter}':");
                if (similarities.Count > 0)
                {
                    foreach (var person in similarities)
                        Console.WriteLine(person.ToString());
                }
                else
                    Console.WriteLine("Прізвищ з такою останньою буквою не знайдено");
            }

            void AddNewMember(List<Member> list)
            {
                try
                {
                    Console.WriteLine("1 - додати гравця. 2 - додати тренера");
                    string type = Console.ReadLine();

                    Console.Write("Прізвище: ");
                    string s = Console.ReadLine();
                    Console.Write("Вік: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Зріст: ");
                    int h = int.Parse(Console.ReadLine());
                    if (type == "1")
                    {
                        Console.Write("Позиція: ");
                        string p = Console.ReadLine();
                        Console.Write("Номер: ");
                        int n = int.Parse(Console.ReadLine());
                        list.Add(new Player(s, a, h, p, n));
                    }

                    else
                    {
                        Console.Write("Досвід: ");
                        int e = int.Parse(Console.ReadLine());
                        list.Add(new Coach(s, a, h, e));
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Помилка: Вік, зріст, номер та досвід мають бути числами!");
                }
            }

            void DeleteMember(List<Member> list)
            {
                if (list.Count == 0)
                {
                    Console.WriteLine("Список порожній, нікого видаляти.");
                    return;
                }
                try
                {
                    Console.Write($"Введіть номер учасника (від 1 до {list.Count}): ");
                    int users_num = int.Parse(Console.ReadLine());
                    if (users_num > 0 && users_num <= list.Count)
                    {
                        list.RemoveAt(users_num - 1);
                        Console.WriteLine("Учасника видалено успішно!");
                    }
                    else
                        Console.WriteLine("Учасника з таким порядковим номером немає!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Помилка: Введіть коректне число.");
                }
            }

            void SaveToFile(List<Member> list)
            {
                try
                {
                    string[] lines = new string[list.Count];
                for (int i = 0; i < list.Count; i++)
                {
                    string type = list[i].GetType().Name;
                    string line = $"{type}|{list[i].surname}|{list[i].age}|{list[i].height}";
                    if (list[i] is Player p)
                        line += $"|{p.position}|{p.number}";
                    else if (list[i] is Coach c)
                        line += $"|{c.experience}";
                    lines[i] = line;
                }
                File.WriteAllLines("Members.txt", lines);
                Console.WriteLine("Дані успішно збережено у файл Members.txt");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка запису у файл: " + ex.Message);
                }
            }

            void LoadFromFile(List<Member> list)
            {
                try
                {
                    if (File.Exists("Members.txt"))
                {
                    string[] lines = File.ReadAllLines("Members.txt");
                    list.Clear();
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        string type = parts[0];
                        string surname = parts[1];
                        int age = int.Parse(parts[2]);
                        int height = int.Parse(parts[3]);
                        if (type == "Player")
                        {
                            string position = parts[4];
                            int number = int.Parse(parts[5]);
                            list.Add(new Player(surname, age, height, position, number));
                        }
                        else if (type == "Coach")
                        {
                            int experience = int.Parse(parts[4]);
                            list.Add(new Coach(surname, age, height, experience));
                        }
                    }
                    Console.WriteLine("Дані успішно завантажено з файлу Members.txt");
                }
                else
                    Console.WriteLine("Файл Members.txt не знайдено!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка завантаження. Файл може бути пошкоджений: " + ex.Message);
                }
            }
        }
    }
}
