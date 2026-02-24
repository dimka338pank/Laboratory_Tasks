using System;


namespace Task1
{
    internal class Player : Member
    {
        public string position { get; set; }
        public int number { get; set; }
        
        public Player(string surname, int age, int height, string position, int number) 
            : base(surname, age, height)
        {
            this.position = position;
            this.number = number;
        }
        
        public override string ToString()
        {
            return base.ToString() + $"; Позиція: {position}; Номер: {number}";
        }
    }
    
}
