using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Implementations
{
    public class HitAbility : IAbility
    {
        public void DoAction()
        {
            Console.WriteLine("Hit");
        }
    }
}
