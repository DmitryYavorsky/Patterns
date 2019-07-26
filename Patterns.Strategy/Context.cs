using System;
using System.Collections.Generic;
using System.Text;
using Patterns.Strategy.Interfaces;

namespace Patterns.Strategy
{
    public class Context
    {
        private IMoveable _move;

        public Context(IMoveable move)
        {
            _move = move;
        }

        public void DoAction()
        {
            _move.Move();
        }
    }
}
