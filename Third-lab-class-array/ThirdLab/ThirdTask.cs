namespace ThirdLab
{
    internal  class ThirdTask
    {
        public static void CompleteThirdTask()
        {
            int[][] arrays = [new int[4], new int[5], new int[3]];

            int sum = 0;

            arrays = FillInArray(arrays);

            Console.Write("Наш ступенчатый массив:\n");
            ShowArray(arrays);

            foreach (int[] array in arrays)
                sum += array.Sum();

            Console.Write("\nСумма всех элементов массива: " + sum);

            foreach (int[] array in arrays)
                Array.Sort(array);

            Console.Write("\nМассив с отсортированными элементами:\n");
            ShowArray(arrays);
        }

        static int[][] FillInArray(int[][] array)
        {
            Random rand = new();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    array[i][j] = rand.Next(1, 43);
            }
            return array;
        }

        static void ShowArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write(array[i][j] + " ");
                Console.WriteLine();
            }
        }
    }
}
