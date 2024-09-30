using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число для обчислення факторіала: ");
        int number = int.Parse(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Факторіал числа {number} = {factorial}");
    }
}

