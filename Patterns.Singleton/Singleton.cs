using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public sealed class Singleton
    {
        //Lazy loading so it'll be initiated only when we need it.
        //Should be statis as there will be only on object of singleton
        private static readonly Lazy<Singleton> singleton = new Lazy<Singleton>(()=> new Singleton());

        public DateTime Date { get; set; }

        private Singleton()
        {
            Date = DateTime.Now;
        }
        public static Singleton GetInstance()
        {
            return singleton.Value;
        }
    }
}
