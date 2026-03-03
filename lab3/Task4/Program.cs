using System;
using System.Text.RegularExpressions;

namespace Task4
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string str1 = "   Це   приклад   рядка   з  зайвими  пропусками.   ";
            string str2 = "У великій мисці збити яйця і цукор.\r\nЧастину молока підігріти, посолити,            і ретельно перемішати зі збитими яйцями і цукром.\r\nВ отриману суміш поступово додавати борошно, постійно перемішуючи, аби не було грудочок.\r\nДодати трішечки соди, сіль і олію. Перемішати.\r\nДодати решту молока і збити. Тісто повинно бути в міру рідким.\r\nРозігріти сковороду.\r\nОбсмажити млинець з обох боків до золотистого кольору.";
            string clearstr1 = str1.RemoveExtraSpaces();
            string clearstr2 = str2.RemoveExtraSpaces();//без this: string cleanstr2 = StringExtensions.RemoveExtraSpaces(str2);
            Console.WriteLine("Початкові рядки:");
            Console.WriteLine(str1);
            Console.WriteLine(str2 + "\n\n");
            Console.WriteLine("\n\n\nКінцеві рядки\n\n\n");
            Console.WriteLine(clearstr1);
            Console.WriteLine(clearstr2);
        }
    }
}
