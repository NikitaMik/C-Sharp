using System;

namespace AbstractFactory_Net
{
    class GreenHousing : IAbstractHousing
    {
        public void Assemble(IAbstractRod rod, IAbstractCap cap)
        {
            Console.WriteLine("Сборка зеленой ручки из {0}, {1}, {2}.", this, rod, cap);
        }
    }
}
