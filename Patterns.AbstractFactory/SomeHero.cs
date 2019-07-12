using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.AbstractFactory.Implementations;
using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory
{
   public class SomeHero
   {
        private IStatus _status;
        private IAbility _ability;
        public SomeHero(IAbilityFactory factory)
        {
            _status = factory.CreateStatus();
            _ability = factory.CreateAbility();
            Console.WriteLine();
        }

        public string getHeroStatus()
        {
            return _status.GetStatus();
        }
    }
}
