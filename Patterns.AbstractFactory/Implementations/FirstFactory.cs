using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Implementations
{
    public class FirstFactory : IAbilityFactory
    {
        public IAbility CreateAbility()
        {
            return  new HitAbility();
        }

        public IStatus CreateStatus()
        {
            return new Status();
        }
    }
}
