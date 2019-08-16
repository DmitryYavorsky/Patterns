using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Interfaces;

namespace Adapter.Implementations
{
    public class ClientDriver
    {
        public void Drive(ITransportFunction function)
        {
            function.Transport();
        }
    }
}
