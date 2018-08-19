using System;

namespace AdapterPlugable
{
    interface ISubject
    {
        void Take();
    }

    class Subject : ISubject
    {
        public void Take()
        {
            Console.WriteLine("Взять любой предмет.");
        }
    }
}
