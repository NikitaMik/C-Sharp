using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaComponent pizza = new BasisPizzaComponent();
            Decorator bacon = new BaconDecorator();
            Decorator catsup = new CatsupDecorator();

            catsup.Component = pizza;
            bacon.Component = catsup;

            bacon.MakePizza();

            Console.ReadKey();
        }
    }
}
