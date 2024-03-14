using System;

namespace GeometryExample.Exercise2
{
    public class Lion : Animal
    {
        public Lion(double weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"Lion Name: {Name}, Weight: {Weight}kg");
        }
    }
}