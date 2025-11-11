using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLab
{
    internal class SecondTask
    {
        public static void CompleteTheSecondTask()
        {
            Console.Write("Введите любую строку: ");
            string? userInput = Console.ReadLine();

            Console.Write("\nТеперь введите подстроку, которую вы хотите заменить: ");
            string? userSubstring = Console.ReadLine();

            Console.Write("\nВведите строку, которая заменит выше указанные подстроки: ");
            string? userSubstringChange = Console.ReadLine();

            Console.Write("\nИзменённая строка: " + userInput.Replace(userSubstring, userSubstringChange));
        }
    }
}
