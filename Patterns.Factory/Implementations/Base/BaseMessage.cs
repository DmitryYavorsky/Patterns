using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Factory.Interfaces;

namespace Patterns.Factory.Implementations.Base
{
    //Abstract product , helps us to create new products via implementing constructor
    public abstract class BaseMessage : IMessage
    {
        public string Text { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }

        public BaseMessage(string text,string source, string destination)
        {
            Text = text;
            Source = source;
            Destination = destination;
        }

        public abstract void Send();

    }
}
