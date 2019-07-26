using System;
using Patterns.Strategy.Implementations;

namespace Patterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Current disign patterv provide us a set of alghoritms inherited from base interface , incapsulete each of them and provide  interchangeability
                       Context context = new Context(new HandMove());
           context.DoAction();
           Console.ReadLine();
        }
    }
}
