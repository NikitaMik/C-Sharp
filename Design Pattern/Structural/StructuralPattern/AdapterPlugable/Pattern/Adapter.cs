using System;

namespace AdapterPlugable
{
    enum SubjectAdaptee
    {
        List, Pen, Notebook
    }

    class SubjectAdapter : ISubject
    {
        Action subjectAction;

        public SubjectAdapter(SubjectAdaptee adaptee)
        {
            switch (adaptee)
            {
                case SubjectAdaptee.List:
                    {
                        subjectAction = new List().ListTake;
                    }
                    break;
                case SubjectAdaptee.Pen:
                    {
                        subjectAction = new Pen().PenTake;
                    }
                    break;
                case SubjectAdaptee.Notebook:
                    {
                        subjectAction = new Notebook().NotebookTake;
                    }
                    break;
            }
        }


        void ISubject.Take()
        {
            subjectAction.Invoke();
        }
    }
}
