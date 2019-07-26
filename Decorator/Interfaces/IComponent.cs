using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Interfaces
{
    public interface IComponent
    {
        string Text { get; set; }
        void Draw();
    }
}
