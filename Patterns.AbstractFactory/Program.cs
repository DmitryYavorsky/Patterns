using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.AbstractFactory.Implementations;

namespace Patterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var hero = new SomeHero(new FirstFactory());
            Console.WriteLine(hero.GetHashCode());
        }
    }
}
