using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача6 
{
    class Car
    {
        internal string person;
        internal string role;
        public Car()
        {

        }
        public void Role(string role, string person)
        {
            if (role == "Водитель")
            {
                Console.WriteLine(person + " - водитель");
            }
            else
            {
                Console.WriteLine(person + "- пассажир");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.person = "Миша";
            car1.role = "Водитель";
            Car car2 = new Car();
            car2.person = "Маша";
            car2.role = "Пассажир";
            Car car3 = new Car();
            car3.person = "Саша";
            car3.role = "Пассажир";
            Car car4 = new Car();
            car4.person = "Даша";
            car4.role = "Пассажир";
            car1.Role(car1.role, car1.person);
            car2.Role(car2.role, car2.person);
            car3.Role(car3.role, car3.person);
            car4.Role(car4.role, car4.person);
            Console.ReadLine();

        }
    }
}

