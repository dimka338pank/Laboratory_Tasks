using System;

namespace Task1
{
    internal class Member
    {
        public string surname { get; set; }
        public int age { get; set;}
        public int height { get; set; }
        
        public Member(string surname, int age, int height)
        {
            this.surname = surname;
            this.age = age;
            this.height = height;
        }
        public override string ToString()
        {
            return $"Прізвище: {surname}; Вік: {age}; Зріст: {height}";
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
