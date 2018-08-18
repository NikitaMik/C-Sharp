using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade car = new Facade();

            Console.WriteLine("Зажигание машины...");
            car.Ignition();
            Console.WriteLine("");

            Console.WriteLine("Нажатие на педаль газа...");
            car.Gas();
            Console.WriteLine("");

            Console.WriteLine("Нажатие на педаль тормоза...");
            car.Brake();
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
