using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype.Interfaces
{
    public interface IPrototype
    {
        IPrototype Clone();
        IPrototype DeepClone();
    }
}
