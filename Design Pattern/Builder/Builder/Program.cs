﻿using System;

//N. Mikurov
namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
  
            //Тетрадь
            NotebookBuilder builder = new NotebookBuilder();
            Director director = new Director(builder);
            director.Construct();
            
            Notebook notebook = builder.GetNotebook();


            //Ежедневник
            DiaryBuilder builderDiary = new DiaryBuilder();
            Director directorDiary = new Director(builderDiary);
            directorDiary.Construct();

            Diary diary = builderDiary.GetNotebook();


            Console.ReadKey();
        }
    }
}
