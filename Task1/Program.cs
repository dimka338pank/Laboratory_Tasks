using System;
using System.Collections.Generic;
using static Task1.Entities;
using static Task1.Entities.Player;

namespace Task1
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            ClubFunctions manager_of_functions = new ClubFunctions();
            ConsolePrinter printer = new ConsolePrinter();

            Country ukraine = new Country("Україна");
            Country usa = new Country("Америка");
            Country poland = new Country("Польща");

            List<Player> teamPlayers = new List<Player>
            {
                new Player("Волинцюга", "Захисник", ukraine),
                new Player("Заєц", "Нападник", ukraine),
                new Player("Продіолус", "Півзахисник", usa),
                new Player("Дєдуч", "Воротар", ukraine),
                new Player("Панькевич", "Нападник", poland),
                new Player("Жанулька", "Наглядач", poland)
            };

            FootballClub club = new FootballClub("ліцейчик", teamPlayers);

            Console.WriteLine($"Клуб: {club.club_name}");
            printer.PrintPlayers(club.players, "Початковий склад");

            manager_of_functions.SortSurnames(club.players);
            printer.PrintPlayers(club.players, "Список після сортування");

            Console.Write("Введіть останню літеру прізвища для пошуку: ");
            string user_input = Console.ReadLine();

            if (!string.IsNullOrEmpty(user_input))
            {
                char letter = user_input[0];

                List<Player> searchResult = manager_of_functions.SearchByLastLetter(club.players, letter);
                printer.PrintPlayers(searchResult, $"Результати пошуку за літерою '{letter}'");

            }
        }
    }
}
