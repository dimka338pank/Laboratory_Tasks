using System.Collections.Generic;

namespace Task1
{
    public class Entities
    {
        /// <summary>
        /// Допоміжний Клас, що представляє країну
        /// </summary>
        public class Country
        {
            public string country_name { get; set; }
            public Country(string country_name)
            {
                this.country_name = country_name;
            }
            public override string ToString()
            {
                return country_name;
            }
        }
        /// <summary>
        /// Клас-сутність, що представляє гравця
        /// </summary>
        public class Player
        {
            public string surname { get; set; }
            public string position { get; set; }
            public Country citizenship { get; set; }
            /// <summary>
            /// Об'єкт допоміжного класу Country (країна гравця).
            /// </summary>
            public Player(string surname, string position, Country citizenship)
            {
                this.surname = surname;
                this.position = position;
                this.citizenship = citizenship;
            }
            public override string ToString()
            {
                return $"{surname} - {position} - {citizenship}";
            }
            /// <summary>
            /// Клас представлення групи сутностей (Футбольний клуб)
            /// </summary>
            public class FootballClub
            {
                public string club_name { get; set; }
                public List<Player> players { get; set; }

                public FootballClub(string club_name, List<Player> players)
                {
                    this.club_name = club_name;
                    this.players = players;
                }
            }
        }
    }
}
