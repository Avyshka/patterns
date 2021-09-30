using System;

namespace patternsHomework_1
{
    public static class Utils
    {
        private static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        public static int Factorial(int x)
        {
            int factorial = 1;
            for (int i = 1; i <= x; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static int SumTo(int x)
        {
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int MaxEvenLess(int x)
        {
            return IsEven(x) ? x : x - 1;
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
        
        public static void ShowGreeting()
        {
            ShowMessage("Здравствуйте вас приветствует математическая программа");
        }
        
        public static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Program
    {
        private const string Quit = "q";

        private static void Main(string[] args)
        {
            Utils.ShowGreeting();
            RunApp();
            Utils.Pause();
        }

        private static void RunApp()
        {
            Utils.ShowMessage("пажалуйста введите число.");

            string inputData = Console.ReadLine();
            bool isNumber = Int32.TryParse(inputData, out int inputNumber);

            if (inputData == Quit || !isNumber)
            {
                return;
            }

            Utils.ShowMessage($"Факториал {inputNumber} равен {Utils.Factorial(inputNumber)}");
            Utils.ShowMessage($"Сумма от 1 до {inputNumber} равна {Utils.SumTo(inputNumber)}");
            Utils.ShowMessage($"максимальное четное число меньше {inputNumber} равно {Utils.MaxEvenLess(inputNumber)}");
        }
    }
}