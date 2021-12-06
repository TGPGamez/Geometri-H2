using Geometri_H2.Shapes;
using System;
using System.Collections.Generic;

namespace Geometri_H2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>() 
            { 
                new Square(64), 
                new Rectangle(48, 16), 
                new Triangle(32, 64), 
                new Parallelogram(6, 10, 40), 
                new Trapeze(20, 18, 16, 18)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name}: {shape}");
            }
        }
    }
}
