﻿using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Write writePen = new Pen();
            writePen.words = "Pen write";
            writePen.WriteWords();


            Write writePainbush = new Adapter();
            writePainbush.words = "Painbush write";
            writePainbush.WriteWords();

            Console.ReadKey();
        }
    }
}
