using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во символов: ");
            int minSymbols = int.Parse(Console.ReadLine());
            StringBuilder triangle = new StringBuilder();
            for (int i = 1; i <= minSymbols; i++)
            {
                triangle.Append(' ', minSymbols - i);
                for (int j = 0; j < i * 2 - 1; j++)
                {
                    triangle.Append('3');
                }
                triangle.AppendLine();
            }
            Console.WriteLine(triangle.ToString());
            Console.ReadKey();
        }
    }
}