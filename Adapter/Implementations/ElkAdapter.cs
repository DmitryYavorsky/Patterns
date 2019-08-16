using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Interfaces;

namespace Adapter.Implementations
{
    public class ElkAdapter : Elk, ITransportFunction
    {
        public void Transport()
        {
            this.Move();
        }
    }
}
