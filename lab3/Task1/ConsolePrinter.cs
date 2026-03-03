using System;
using System.Collections.Generic;
using static Task1.Entities;

namespace Task1
{
    /// <summary>
    /// Клас для форматованого виведення даних у консоль.
    /// </summary>
    internal class ConsolePrinter
    {
        /// <summary>
        /// Виводить список гравців у вигляді таблиці.
        /// </summary>
        public void PrintPlayers(List<Player> players, string title)
        {
            Console.WriteLine($"\n{title}");
            if (players.Count == 0)
            {
                Console.WriteLine("Список порожній.");
                return;
            }
            foreach (Player player in players)
            {
                Console.WriteLine($"{player.surname} - {player.position} - {player.citizenship}");
            }

        }
    }
}
