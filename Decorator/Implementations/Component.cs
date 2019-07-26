using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Interfaces;

namespace Decorator.Implementations
{
    public class Component : IComponent
    {
        public string Text { get; set; }

        public void Draw()
        {
            Console.WriteLine("Base component " + this.Text);
            
        }
    }
}
