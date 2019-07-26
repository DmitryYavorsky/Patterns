using System;
using System.Globalization;
using Observer.Implementations;
using Observer.Interfaces;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Subject();
            ConcreteObserver obs = new ConcreteObserver(subject);
            subject.Notify();
            Console.ReadLine();

        }
    }
}
