using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> singleton = new Lazy<Singleton>();

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
