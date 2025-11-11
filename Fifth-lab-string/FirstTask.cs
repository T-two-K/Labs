using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLab
{
    internal class FirstTask
    {
        public static void CompleteTheFirstTask()
        {
            Console.Write("Введите любую строку: ");
            string? userInput = Console.ReadLine();

            string[] array = userInput.Split(' ');
            Array.Reverse(array);

            foreach (string c in array)
            {
                Console.Write(c + " ");
            }
        }
    }
}
