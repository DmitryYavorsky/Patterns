using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Builder.Implementations
{
    public class Product
    {
        List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }
    }
}
