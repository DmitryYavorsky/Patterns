using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Observer.Interfaces
{
    public interface ISubject
    {
        event EventHandler eventHandler;
        void Notify();
    }
}
