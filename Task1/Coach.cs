using System;

namespace Task1
{
    internal class Coach : Member
    {   
        public int experience { get; set; }
        public Coach(string surname, int age, int height, int experience) 
            : base(surname, age, height)
        {
            this.experience = experience;
        }
        public override string ToString()
        {
            return base.ToString() + $"; Досвід: {experience} років;";
        }
    }
}
