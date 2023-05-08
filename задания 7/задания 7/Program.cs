using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задания_7
{
    internal class Program
    {
        public class needbook
        {
            public List<string> Page { get; set; }
            public needbook(int countPage)
            {
                Page = new List<string>();
                for (int a = 0 ; a < countPage; a++)
                {
                    Page.Add("");
                }
            }  
            public void write (int page, string word)
            {
                 
                if (page <1 || page > Page.Count) 
                {
                    Console.WriteLine("Ошибка: страница не найдена!");
                    return;
                }
                word = word.Trim();
                string wr = Page[page - 1];
                int writeSimvols = wr.Length;
                int lastPage = 10 - writeSimvols;

                if (writeSimvols > 0)
                {
                    word = word.PadLeft(word.Length + 1);
                }
                StringBuilder sb = new StringBuilder(wr);
                sb.Insert(writeSimvols, word);
                Page[page - 1] = sb.ToString();
            }

            public void ВывестиСтраницы()
            {
                for (int i = 0; i < Page.Count; i++)
                {
                    Console.WriteLine("Страница {0}: {1}", i + 1, Page[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            needbook notebook = new needbook(15);
            notebook.write(1, "Hello");
            notebook.write(2, "paka");
            notebook.write(8, "flower");
            notebook.write(12, "sun");
            notebook.write(12, "and moon");
            
            notebook.ВывестиСтраницы();
        }
    }
}
