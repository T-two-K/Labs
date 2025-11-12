using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КПиЯП_Л6
{
    internal class SecondTask
    {
        private char[] _alphabet;
        private int _currentIndex;
        public StringBuilder OurString;

        public SecondTask()
        {
            _alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
        }

        public void CompleteSecondTask()
        {
            Console.WriteLine("Введите ваш текст: ");
            string? textInput = Console.ReadLine();  

            Console.WriteLine("На какое количество символов нужно сдвинуть вашу строку?");
            string? shiftInput = Console.ReadLine();  

            int shift = 0;
            if (!int.TryParse(shiftInput, out shift))
            {
                Console.WriteLine("Неверный сдвиг, используем 0.");
            }

            OurString = new StringBuilder(textInput?.ToUpper() ?? string.Empty);

            for (int i = 0; i < OurString.Length; i++)
            {
                char currentChar = OurString[i];
                _currentIndex = Array.IndexOf(_alphabet, currentChar);

                if (_currentIndex != -1) 
                {
                    int newIndex = (_currentIndex + shift) % _alphabet.Length;
                    char newChar = _alphabet[newIndex];
                    OurString.Replace(currentChar, newChar, i, 1);
                }
            }

            Console.WriteLine("Зашифрованный текст: " + OurString.ToString());
        }
    }
}
