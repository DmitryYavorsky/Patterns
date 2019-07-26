using System;
using System.Collections.Generic;
using System.Text;
using Observer.Interfaces;

namespace Observer.Implementations
{
    public class Subject : ISubject
    {
        public event EventHandler eventHandler;

        public void Notify()
        {
            if(eventHandler!=null) 
                eventHandler(this,EventArgs.Empty);
        }
    }
}
