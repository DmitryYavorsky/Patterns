using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Prototype.Implementations;
using Patterns.Prototype.Interfaces;

namespace Patterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle()
            {
                X = 1,
                Y = 2,
                Point = new Point { X = 5, Y = 5}
            };
            var clonedCircle = (Circle)circle.DeepClone();
            clonedCircle.Point.Y = 3;
            Console.WriteLine("X " +  circle.Point.Y);
            Console.WriteLine("X " + clonedCircle.Point.Y );
            Console.ReadLine();
        }
    }
}
