using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть перше число: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int number2 = int.Parse(Console.ReadLine());

        int gcd = FindGCD(number1, number2);

        Console.WriteLine($"Найбільший спільний дільник для {number1} і {number2} = {gcd}");
    }

    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
