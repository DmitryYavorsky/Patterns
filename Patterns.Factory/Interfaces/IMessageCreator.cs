using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory.Interfaces
{
    public interface IMessageCreator
    {
        IMessage CreateMessage(string text, string source, string destination);
    }
}
