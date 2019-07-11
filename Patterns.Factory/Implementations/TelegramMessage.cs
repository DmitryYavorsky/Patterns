using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Factory.Implementations.Base;

namespace Patterns.Factory.Implementations
{
    //Concrete product
    public class TelegramMessage : BaseMessage
    {
        public TelegramMessage(string text, string source, string destination) : base(text, source, destination)
        {
        }

        public override void Send()
        {
           //Sending process
        }
    }
}
