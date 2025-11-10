namespace ThirdLab
{
    internal class SecondTask
    {
        public static void CompleteSecondTask()
        {
            Console.Write("Введите количество строк: ");
            string? userInput = Console.ReadLine();
            int cols = ConvertToInt(userInput);

            Console.Write("Введите количество столбцов: ");
            userInput = Console.ReadLine();
            int rows = ConvertToInt(userInput);

            int[,] firstArray = new int[cols, rows];
            int[,] secondArray = new int[cols, rows];

            firstArray = FillInArray(firstArray);
            secondArray = FillInArray(secondArray);

            Console.Write("\nПервый массив:\n");
            ShowArray(firstArray);
            Console.Write("\nВторой массив:\n");
            ShowArray(secondArray);

            int[,] arraySum = new int[cols, rows];
            arraySum = FindArraySum(arraySum, firstArray, secondArray);
            Console.Write("\nСумма массивов:\n");
            ShowArray(arraySum);

            Console.Write("\nТранспонированный массив:\n");
            int[,] transparentArray = Transparent(arraySum);
            ShowArray(transparentArray);
        }

        static int[,] FillInArray(int[,] array)
        {
            Random rand = new();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = rand.Next(1, 34);
            return array;
        }

        static int[,] Transparent(int[,] array)
        {
            int[,] transparentArray = new int[array.GetLength(1), array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    transparentArray[j, i] = array[i, j];
            return transparentArray;
        }

        static int[,] FindArraySum(int[,] arraySum, int[,] firstArray, int[,] secondArray)
        {
            if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.GetLength(0); i++)
                    for (int j = 0; j < firstArray.GetLength(1); j++)
                        arraySum[i, j] = secondArray[i, j] + firstArray[i, j];
                return arraySum;
            }
            else
            {
                Console.WriteLine("Матрицы не суммируются.");
                return arraySum = new int[,] { { 0 } };
            }
        }

        static void ShowArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + " ");
                Console.Write("\n");
            }
        }

        static int ConvertToInt(string? str)
        {
            if (int.TryParse(str, out int value)) return value;
            else
            {
                Console.WriteLine("Вы ввели неверные данные. Программа завершает свою работу.");
                System.Environment.Exit(0);
                return 0;
            }
        }
    }
}
