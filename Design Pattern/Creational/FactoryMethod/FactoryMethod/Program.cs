using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = null;
            Product product = null;

            creator = new PenCreator();
            product = creator.FactoryMethod();

            product.NameProduct();

            Console.ReadKey();
        }
    }
}
