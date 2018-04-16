using System;

namespace AbstractFactory_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client;

            Console.WriteLine("Синия ручка");
            client = new Client(new BlueFactory());
            client.Run();

            Console.WriteLine("\nЗеленая ручка");
            client = new Client(new GreenFactory());
            client.Run();

            Console.ReadKey();
        }
    }
}
//Абстрактная фабрика 
