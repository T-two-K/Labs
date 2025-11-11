namespace FourthLab
{
    internal class SecondTask
    {
        public static void CompleteSecondTask()
        {
            int firstWholNumber = 10;
            int secondWholNumber = 14;

            double firstFractionalNumber = 34.4;
            double secondFractionalNumber = 23.7;

            string firstStringNumber = "139";
            string secondStringNumber = "9";

            int wholSum = AddNumbers(firstWholNumber, secondWholNumber);
            int wholSubtract = Subtract(firstWholNumber, secondWholNumber);  

            double fractionSum = AddNumbers(firstFractionalNumber, secondFractionalNumber);
            double fractionSubtract = Subtract(firstFractionalNumber, secondFractionalNumber);

            string stringSum = AddNumbers(firstStringNumber, secondStringNumber);
            string stringSubtract = Subtract(firstStringNumber, secondStringNumber);

            Console.WriteLine($"Сумма целых чисел: {wholSum}\nРазность целых чисел: {wholSubtract}\nСумма дробных чисел: {fractionSum}\n" +
                $"Разность дробных чисел: {fractionSubtract}\nСумма строк: {stringSum}\nРазность строк: {stringSubtract}");
        }

        static int AddNumbers(int firstNumber, int SecondNumber)
        {
            return firstNumber + SecondNumber;
        }

        static double AddNumbers(double firstNumber, double SecondNumber)
        {
            return firstNumber + SecondNumber;
        }

        static string AddNumbers(string firstNumber, string SecondNumber)
        {
            return firstNumber + SecondNumber;
        }

        static int Subtract(int firstNumber, int SecondNumber)
        {
            return firstNumber - SecondNumber;
        }

        static double Subtract(double firstNumber, double SecondNumber)
        {
            return firstNumber - SecondNumber;
        }

        static string Subtract(string firstNumber, string SecondNumber)
        {
            return firstNumber.Replace(SecondNumber, "");
        }
    }
}
