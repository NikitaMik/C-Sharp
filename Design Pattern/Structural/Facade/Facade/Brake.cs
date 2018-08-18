using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Brake
    {
        public void OperationA()
        {
            Console.WriteLine("Рычаг толкает поршень.");
        }
        public void OperationB()
        {
            Console.WriteLine("Нарастающие давление в тормозной жидкости.");
        }
        public void OperationC()
        {
            Console.WriteLine("В тормозном цилиндре колеса зажимает тормозную колодку.");
        }
    }
}
