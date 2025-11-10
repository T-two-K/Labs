namespace ThirdLab
{
    internal class FirstTask
    {
        public static void CompleteFirstTask()
        {
            int[]? array = new int[10];

            array = FillInArray(array);
            ShowArray(array);

            Console.Write("\nМассив был отсортирован: \n");
            Array.Sort(array);
            ShowArray(array);

            int? sum = array.Sum();

            Console.Write("\nСумма всех элементов массива: " + sum);

            int[] copyArray = new int[array.Length];

            Console.Write("\nБыло произведено копирование элементов из одного массива в другой: ");
            Array.Copy(array, copyArray, array.Length);
            ShowArray(copyArray);
            Console.Write("\nEnter value: ");
            int searchValue = int.Parse(Console.ReadLine());
            int lastIndex = Array.LastIndexOf(array, searchValue);
            Console.WriteLine("\nИндекс искомого последнего элемента массива: " + lastIndex);
        }

        static int[] FillInArray(int[] array)
        {
            Random rand = new();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(1, 45);
            return array;
        }

        static void ShowArray(int[] array)
        {
            Console.Write("Наш массив:\n");
            foreach (int element in array)
                Console.Write(element + " ");
        }
    }
}
