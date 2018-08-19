using System;
using System.Collections.Generic;

namespace AdapterPlugable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISubject> subject = new List<ISubject>();

            subject.Add(new Subject());
            subject.Add(new SubjectAdapter(SubjectAdaptee.List));
            subject.Add(new SubjectAdapter(SubjectAdaptee.Pen));
            subject.Add(new SubjectAdapter(SubjectAdaptee.Notebook));

            foreach (ISubject elem in subject)
                elem.Take();

            Console.ReadKey();
        }
    }
}
