using System;

class Program
{
    static void Main(string[] args)
    {
        int number1, number2, sum;

        Console.Write("Введите первое число: ");
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        number2 = int.Parse(Console.ReadLine());

        sum = number1 + number2;

        Console.WriteLine("Сумма двух чисел: " + sum);
    }
}

