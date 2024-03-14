using System;

namespace GeometryExample.Exercise2
{
    public class Tiger : Animal
    {
        public Tiger(double weight, string name) : base(weight, name) { }

        public override void Show()
        {
            Console.WriteLine($"Tiger Name: {Name}, Weight: {Weight}kg");
        }
    }

}