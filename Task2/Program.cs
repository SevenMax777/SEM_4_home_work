using System;

class Program
{
    static void Main(string[] args)
    {
        const int n = 10;
        int[] array = new int[n];

        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        int countEven = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                countEven++;
            }
        }

        Console.WriteLine($"Количество четных чисел в массиве: {countEven}");
    }
}
