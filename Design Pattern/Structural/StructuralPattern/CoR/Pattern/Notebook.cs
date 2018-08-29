using System;

namespace CoR
{
    class Notebook : Handler
    {
        public override void Request(string name, string text)
        {
            if (name == "Notebook")
            {
                Console.WriteLine("Блокнот: " + text);
            }
            else
            {
                base.Request(name, text);
            }
        }
    }
}
