using System;
using System.Collections.Generic;
using System.Text;
using Observer.Interfaces;

namespace Observer.Implementations
{
    public class ConcreteObserver : IObserver
    {
        private readonly ISubject _subject;
        public ConcreteObserver(ISubject subject)
        {
            _subject = subject;
            Subscribe();
        }
        public void DoSomething(object sender, EventArgs eventHandler)
        {
            Console.WriteLine("Callded");
           Console.WriteLine(sender.ToString());
        }

        public void Subscribe()
        {
            _subject.eventHandler +=DoSomething;
        }

        public void Unsubscribe()
        {
            _subject.eventHandler -= DoSomething;
        }
    }
}
