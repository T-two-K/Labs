namespace FromLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MakeThirdExercise();

        }

        static void MakeThirdExercise()
        {
            Console.Write("Введите натуральное число: ");
            int naturalNumber = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            double finalResult = 1;

            for (int i = 1; i < naturalNumber; i++)
            {
                result = result + Math.Cos(Math.Cos(i)) / Math.Sin(Math.Sin(i));
                finalResult *= result;
            }

            Console.WriteLine($"Финальный результат: {finalResult}");
        }

        static void MakeFirstExercise()
        {
            Console.Write("Введите переменную X и Y:\nПеременная X: ");
            string pointX = Console.ReadLine();
            Console.Write("Переменная Y: ");
            string pointY = Console.ReadLine();

            if (double.TryParse(pointX, out double correctX) && double.TryParse(pointY, out double correctY))
            {
                if (correctX != 1)
                {
                    double result = Math.Pow((correctX + 1) / (correctX - 1), correctX);
                    result += Math.Pow(18 * correctX * correctY, 2);
                    Console.Write($"Результат вычисления: {result} ");
                }
                else
                {
                    Console.WriteLine("Ошибка! На 0 делить нельзя!!!");
                }
            }
            else
            {
                Console.WriteLine("Введены неверные данные.");
            }
        }

        static void MakeSecondExercisePartOne()
        {
            Console.Write("Введите число от 1 до 5: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Плохо!");
                    break;
                case 2:
                    Console.WriteLine("Неудовлетворительно.");
                    break;
                case 3:
                    Console.WriteLine("Удовлетворительно.");
                    break;
                case 4:
                    Console.WriteLine("Хорошо");
                    break;
                case 5:
                    Console.WriteLine("Отлично");
                    break;

                default:
                    Console.WriteLine("Вы ввели неверное значение!");
                    break;
            }
        }

        static void MakeSecondExercisePartTwo()
        {
            Console.WriteLine("Введите число любое число: ");
            double pointZ = Convert.ToDouble(Console.ReadLine());
            double pointX;

            if (pointZ < 1)
            {
                pointX = Math.Pow(pointZ, 3) + 0.2;
            }
            else
            {
                pointX = pointZ + Math.Log(pointZ);
            }

            double pointY = Math.Pow(Math.Cos(Math.Pow(pointX, 2)), 3) + Math.Pow(Math.Sin(Math.Sqrt(Math.Pow(pointX, 3))), 2);

            Console.WriteLine($"Результаты вычисления: {pointY} ");
        }
    }
}
