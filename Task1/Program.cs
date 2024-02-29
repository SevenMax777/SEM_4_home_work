using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Введите целое число (q - для выхода): ");
            string input = Console.ReadLine()!;

            if (input == "q")
            {
                break;
            }

            int number;
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Неверный формат числа.");
                continue;
            }

            int sumOfDigits = 0;
            while (number > 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }

            if (sumOfDigits % 2 == 0)
            {
                Console.WriteLine("Сумма цифр числа чётная. Завершение работы.");
                break;
            }
        }
    }
}
