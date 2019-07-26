using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Interfaces;

namespace Decorator.Implementations
{
    public class BaseDecorator : IComponent
    {
        private readonly IComponent _component;
        public BaseDecorator(IComponent component)
        {
            _component = component;
        }

        public virtual string Text
        {
            get { return this._component.Text; }
            set { this._component.Text = value; }
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
