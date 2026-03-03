using System.Collections.Generic;

using static Task1.Entities;

namespace Task1
{
    internal class ClubFunctions
    {
        /// <summary>
        /// Сортує список за довжиною прізвища (від найдовшого до найкоротшого).
        /// </summary>
        public void SortSurnames(List<Player> list)
        {
            list.Sort((a, b) => b.surname.Length.CompareTo(a.surname.Length));
        }
        /// <summary>
        /// Шукає гравців за останньою літерою прізвища.
        /// </summary>
        public List<Player> SearchByLastLetter(List<Player> list, char letter)
        {
            string user_input = letter.ToString().ToLower();
            return list.FindAll(m => m.surname.ToLower().EndsWith(user_input));
        }
    }
}
