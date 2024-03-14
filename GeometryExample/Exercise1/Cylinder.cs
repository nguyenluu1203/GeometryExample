using System;

namespace GeometryExample.Exercise1
{
    public class Cylinder
    {
        public double Radius { get; private set; }
        public double Height { get; private set; }

        public double BaseArea { get; private set; }
        public double LateralArea { get; private set; }
        public double TotalArea { get; private set; }
        public double Volume { get; private set; }

        public void Process()
        {
            Console.WriteLine("Enter the radius of the cylinder");
            Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the cylinder");
            Height = double.Parse(Console.ReadLine());
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine($"Base Area: {BaseArea}");
            Console.WriteLine($"Lateral Area: {LateralArea}");
            Console.WriteLine($"Total Area: {TotalArea}");
            Console.WriteLine($"Volume: {Volume}");
        }
    }
}