using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
  
            Aggregate a = new Library();

            a[0] = new Book("Туманность андромеды", "Ефремов", 2005);
            a[1] = new Book("Над пропастью во ржи", "Сэлинджер", 2016);
            a[2] = new Book("Война и мир", "Толстой", 1998);
            a[3] = new Book("Замок","Кафка ", 2011);

            Iterator i = a.CreateIterator();
                        
            Console.WriteLine("Книги в библиотеке");

            for (Book e = i.First(); !i.IsDone(); e = i.Next())
            {
                Console.WriteLine("Название: {0}, Автор: {1}, Год: {2}.",e.Name, e.Author, e.Year);
            }



            Console.ReadKey();
        }
    }
}
