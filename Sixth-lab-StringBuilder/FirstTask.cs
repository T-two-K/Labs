using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КПиЯП_Л6
{
    internal class FirstTask
    {
        public static void CompleteTheFirstTask()
        {
            var stringBuilder = new StringBuilder(10000);

            AddNewComponent(stringBuilder, "Система запущена.\n");
            AddNewComponent(stringBuilder, "Начало выполнения лабораторной работы.\n");
            Thread.Sleep(1000);
            AddNewComponent(stringBuilder, "Ошибка: нет необходимых данных.\n");
            AddNewComponent(stringBuilder, "Ошибка: нет интернет соединения.\n");
            AddNewComponent(stringBuilder, "Ошибка: отказано в доступе.\n");
            Console.WriteLine($"Capasity = {stringBuilder.Capacity}, Lenght = {stringBuilder.Length}");
            ShowStringBuilder(stringBuilder);

            stringBuilder.Replace("Ошибка", "Предупреждение");

            ShowStringBuilder(stringBuilder);

            AddNewComponent(stringBuilder, "Работа почти завершена\n");
            AddNewComponent(stringBuilder, "Осталось совсем немного!\n");
            AddNewComponent(stringBuilder, "Работа успешно выполнилась!\n");
            Console.WriteLine($"Capasity = {stringBuilder.Capacity}, Lenght = {stringBuilder.Length}");


            stringBuilder.Capacity = stringBuilder.Length;

            ShowStringBuilder(stringBuilder);
            Console.WriteLine($"Capasity = {stringBuilder.Capacity}, Lenght = {stringBuilder.Length}");

        }

        private static void AddNewComponent(StringBuilder stringBuilder, string input)
        {
            stringBuilder.Append($"[{DateTime.Now}] " + input);
        }

        private static  void ShowStringBuilder(StringBuilder stringBuilder)
        {
            Console.WriteLine(stringBuilder);

            Console.WriteLine("\nНажмите любую клавишу.");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
