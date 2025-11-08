namespace SecondLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
        }

        static void SecondTask()
        {
            Random random = new();
            double multiply = 1;
            double sum = 0;

            Console.Write("Введите длину массива: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            double[] ourArray = new double[arrayLength];
            double[] arrayWithAbs = new double[arrayLength];

            ourArray = FillInArray(ourArray, random);

            Console.Write("\nНаш массив:\n");
            ShowMeAnArray(ourArray);

            for (int i = 0; i < arrayLength; i++)
                arrayWithAbs[i] = Math.Abs(ourArray[i]);

            var maxElement = (double)arrayWithAbs.Max(max => max);
            Console.WriteLine("\nМаксимальный элемент по модулю: " + maxElement);

            var minElement = (double)arrayWithAbs.Min(min => min);
            Console.WriteLine("Минимальный элемент по модулю: " + minElement);

            FindMinAndMaxIndexOfElements(arrayWithAbs, out int startIndex, out int endIndex, maxElement, minElement);

            for (int i = 0; i < arrayLength; i++)
                if (ourArray[i] > 0)
                    sum += ourArray[i];

            for (int i = startIndex + 1; i < endIndex - 1; i++)
                multiply *= ourArray[i];

            var sortArray = ourArray.OrderByDescending(element => element).ToArray();

            Console.WriteLine($"\nСумма элементов: {Math.Round(sum, 1)}.");
            Console.WriteLine($"произведение элементов: {multiply}.");

            Console.Write("\nОтсортированный массив:\n");
            ShowMeAnArray(sortArray);



        }

        static void FindMinAndMaxIndexOfElements(double[] array, out int startIndex, out int endIndex, double maxElement, double minElement)
        {
            var indexMaxElement = Array.IndexOf(array, maxElement);
            var indexMinElement = Array.IndexOf(array, minElement);

            if (indexMaxElement > indexMinElement)
            {
                startIndex = indexMinElement;
                endIndex = indexMaxElement;
            }
            else
            {
                startIndex = indexMaxElement;
                endIndex = indexMinElement;
            }
        }

        static void ShowMeAnArray(double[] array)
        {
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }

        static double[] FillInArray(double[] array, Random rand)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(-100, 101) + Math.Round(rand.NextDouble(), 1);
            return array;
        }

        static void FirstTask()
        {
            Random rand = new();
            int[] ourArray = new int[10];
            int countOfNumber = 0;
            int sum = 0;

            ourArray = FillInArray(ourArray, rand);
            ShowMeAnArray(ourArray);

            for (int i = 0; i < ourArray.Length; i++)
                if (ourArray[i] % 7 == 0 && ourArray[i] < 0)
                {
                    sum += ourArray[i];
                    countOfNumber++;
                }

            Console.Write($"\nКоличество отрицательных чисел кратных 7: {countOfNumber}\nИх сумма: {sum}.");


        }

        static int[] FillInArray(int[] array, Random rand)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(-100, 11);
            return array;
        }

        static void ShowMeAnArray(int[] array)
        {
            foreach (var element in array)
                Console.Write(element + " ");
        }
    }

}
