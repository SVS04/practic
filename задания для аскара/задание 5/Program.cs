using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_5
{
    class shop
    {
        public string name;
        public int count;
        public bool door;

        public bool Open(string name)
        {
            Console.WriteLine("Магазин " + name + " открыт ");
            return true;
        }
        public bool Close(string name )
        {
            Console.WriteLine("Магазин " + name + " закрыт ");
            return false;
        }
        public void Omon(bool door, string name )
        {
            if (door)
            {
                Console.WriteLine("В магазин "+ name + " Омон вызван");

            }
            else
            {
                Console.WriteLine("В магазин " + name + " Омон не вызван");
            }
        }
        public void write (string name, bool door, int count)
        {
            if (door)
            {
                Console.WriteLine(" Магазин " + name + " открыт. " + " В магазине " + count + " свободных мест на фудкорте ");
            }
            else
            {
                Console.WriteLine(" Магазин " + name + " закрыт. " + " В магазине " + count + " свободных мест на фудкорте ");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shop Shop1 = new shop();
            Shop1.name = "Южный";
            Shop1.count = 560;
            Shop1.door = false;
            shop Shop2 = new shop();
            Shop2.name = "Мега";
            Shop2.count = 1000;
            Shop2.door = true;
            shop Shop3 = new shop();
            Shop3.name = "Тандем";
            Shop3.count = 888;
            Shop3.door = false;
            Shop1.door = Shop1.Open(Shop1.name);
            Shop2.door = Shop2.Close(Shop2.name);
            Shop1.Omon(Shop1.door, Shop1.name);
            Shop2.Omon(Shop2.door, Shop2.name);
            Shop3.Omon(Shop3.door, Shop3.name);
            Shop1.write(Shop1.name, Shop1.door, Shop1.count);
            Shop2.write(Shop2.name, Shop2.door, Shop2.count);
            Shop3.write(Shop3.name, Shop3.door, Shop3.count);
        }
    }
}
