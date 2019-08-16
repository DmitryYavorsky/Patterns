using System;
using Decorator.Implementations;
using Decorator.Interfaces;


namespace Decorator
{
    class Program
    {
        //Useing decorator we can add new functionality to desired class without changing it
        static void Main(string[] args)
        {
            IComponent comp = new Component();
            comp.Draw();
            comp = new DerivedDrecorator(comp);
            comp.Draw();
            Console.ReadLine();
        }
    }
}
