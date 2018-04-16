using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Зеленая ручка");
            Client client = new Client(Factory.GreenFactory);
            client.Run();

            Console.WriteLine("\nСиния ручка");
            client = new Client(Factory.BlueFactory);
            client.Run();

            // Задержка.
            Console.ReadKey();
        }
    }
}
//Абстрактная фабрика с возможностями языка c#