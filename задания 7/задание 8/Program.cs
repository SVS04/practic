using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_8
{

    internal class Program
    {
        public class ChineMother
        {
            public string FullName { get; set; }
            public int Age { get; set; }
            public string Adress { get; set; }
            public List Сhildren { get; set; }
            public ChineMother(string FullName, int age, string Adress)
            { 
                this.FullName = FullName;
                this.Age = age;
                this.Adress = Adress;
                Children = new List<ChineMother>();
            }

        static void Main(string[] args)
        {
        }
    }
}
