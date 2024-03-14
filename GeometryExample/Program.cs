using System;
using GeometryExample.Exercise1;
using GeometryExample.Exercise2;

namespace GeometryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();
            cylinder.Process();
            cylinder.Result();
            
            
            Lion lion = new Lion(200, "Simba");
            Tiger tiger = new Tiger(150, "Shere Khan");

            lion.Show();
            tiger.Show();
        }
    }
}