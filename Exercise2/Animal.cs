using System;

namespace GeometryExample.Exercise2
{
    public class Animal
    {
        protected double Weight { get; private set; }
        protected string Name { get; private set; }

        public Animal(double weight, string name)
        {
            SetMe(weight, name);
        }

        public void SetMe(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Animal Name: {Name}, Weight: {Weight}kg");
        }
    }
}