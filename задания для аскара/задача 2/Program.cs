using System;

class Program
{
    static void Main(string[] args)
    {
        string str;
        int count;

        Console.Write("Введите строку: ");
        str = Console.ReadLine();

        Console.Write("Введите количество раз: ");
        count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(str);
        }
    }
}

