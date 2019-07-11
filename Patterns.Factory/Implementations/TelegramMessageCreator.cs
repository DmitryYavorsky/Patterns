using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Factory.Implementations.Base;
using Patterns.Factory.Interfaces;

namespace Patterns.Factory.Implementations
{
    public class TelegramMessageCreator : BaseCreator
    {
        public TelegramMessageCreator()
        {
            
        }
        public override IMessage CreateMessage(string text, string source, string destination)
        {
            return new TelegramMessage(text,source,destination);
        }
    }
}
