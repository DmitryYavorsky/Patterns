using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Interfaces;

namespace Decorator.Implementations
{
    public class DerivedDrecorator : BaseDecorator
    {
        public DerivedDrecorator(IComponent component) : base(component)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Deriver decorator");
        }
    }
}
