using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        int limit = int.Parse(Console.ReadLine());

        int a = 0, b = 1, sum = 0, count = 0;

        while (a < limit)
        {
            sum += a;
            count++;

            int temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine($"Сума чисел Фібоначчі, менших за {limit}: {sum}");
        Console.WriteLine($"Кількість елементів: {count}");
    }
}

