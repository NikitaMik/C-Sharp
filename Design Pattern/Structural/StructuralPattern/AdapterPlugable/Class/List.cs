using System;

namespace AdapterPlugable
{
    class List
    {
        public void ListTake()
        {
            Console.WriteLine("Взять лист бумаги.");
        }
    }

    class Pen
    {
        public void PenTake()
        {
            Console.WriteLine("Взять ручку.");
        }
    }

    class Notebook
    {
        public void NotebookTake()
        {
            Console.WriteLine("Взять тетрадь.");
        }
    }
}
