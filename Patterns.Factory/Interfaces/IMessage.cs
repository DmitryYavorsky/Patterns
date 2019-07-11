using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory.Interfaces
{
    public interface IMessage
    {
        string Text { get; set; }
        string Source { get; set; }
        string Destination { get; set; }
        void Send();

    }
}
