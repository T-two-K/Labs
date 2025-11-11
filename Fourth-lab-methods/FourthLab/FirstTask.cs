namespace FourthLab
{
    internal class FirstTask
    {
        public static void CompleteFirstTaskPartB()
        {
            Console.Write("Введите трёхзначное число: ");
            string? userInput = Console.ReadLine();
            if (CheckUserInput(userInput))
            {
                int number = Convert.ToInt32(userInput);
                if (number > 100 && number < 999)
                {
                    int newNumber = Rearrange(number);
                    Console.WriteLine("Число с переставленными элементами: " + newNumber);
                }
                else Console.WriteLine("Необходимо ввести трёхзначное число.");
            }
            else Console.WriteLine("Были введены некорректные данные.");
        }

        static int Rearrange(int number)
        {            
            int rearrangeNumber = 100 * ((number % 100) % 10) + (number % 100 - number % 10) + ((number - number % 100 ) / 100);
            return rearrangeNumber;
        }

        public static void CompleteFirstTaskPartA()
        {
            int[] numbers = new int[3];
            Console.WriteLine("Введите три числа (через enter): ");

            for (int i = 0; i < numbers.Length; i++)
            {
                string userInput = Console.ReadLine();
                if (CheckUserInput(userInput))
                    numbers[i] = Convert.ToInt32(userInput);
                else
                {
                    Console.WriteLine("Был введён некорректный ввод.");
                    numbers[i] = 0;
                }
            }

            string existsTheSameNumbers = FindTheSameNumbers(numbers);

            Console.Write("Есть ли одинаковые числа: " +  existsTheSameNumbers); 

        }

        static bool CheckUserInput(string? userInput)
        {
            if (int.TryParse(userInput, out int number)) return true;
            else return false;
        }

        static string FindTheSameNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; ++i)
            {
                int number = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                    if (numbers[j] == number) return "Yes";
            }

            return "No";
        }
    }
}
