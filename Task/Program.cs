using System;
using System.Threading;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вас приветствует преобразователь чисел !");

            Console.WriteLine("Введите любое число");
            var num = doubleParse();
            Console.WriteLine("Насколько увеличить число?");
            var numAdd = doubleParse();
            Console.WriteLine("Насколько умножить число?");
            var numMultiply = doubleParse();

            Console.Clear();
            Console.WriteLine("Преобразование...");
            Thread.Sleep(2000);
            Console.WriteLine("Успешно!");

            var performNumber = Calculate(num, new Add(numAdd), new Multiply(numMultiply));
            Console.WriteLine($"Результат преобразования = { performNumber }");

            Console.ReadLine();
        }

        private static double Calculate(double number, Add add, Multiply multiply)
        {
            return multiply.Perform(add.Perform(number));
        }

        private static double doubleParse()
        {
            string number;
            while (true)
            {
                number = Console.ReadLine();
                if (double.TryParse(number, out double num))
                {
                    return num;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Не верный формат. Повторите попытку.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
        }
    }
}
