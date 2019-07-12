using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Factory.Interfaces;

namespace Patterns.Factory.Implementations.Base
{
    public abstract class BaseCreator : IMessageCreator
    {
        //Here we have only factory method that we can override in derived class
        public abstract IMessage CreateMessage(string text, string source, string destination);
    }
}
