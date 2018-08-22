using System;

namespace Birdge
{
    class Program
    {
        static void Main(string[] args)
        {
            MaterialImplementor material;
            ShapeAbstraction shape;

            material = new MetalImplementor();
            shape = new CubeAbstraction(material);
            shape.ReadyShape();

            material = new TreeImplementor();
            shape = new CubeAbstraction(material);
            shape.ReadyShape();

            Console.ReadKey();
        }
    }
}
