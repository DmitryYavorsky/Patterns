using System;
using System.Collections.Generic;
using System.Text;
using Patterns.Strategy.Interfaces;

namespace Patterns.Strategy.Implementations
{
    public class LegMove : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("Move leg");
            ;
        }
    }
}
