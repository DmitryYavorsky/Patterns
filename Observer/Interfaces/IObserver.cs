using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Interfaces
{
    public interface IObserver
    {
        void Subscribe();
        void Unsubscribe();
        void DoSomething(object sender,EventArgs eventHandler);
    }
}
