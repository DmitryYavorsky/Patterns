using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Interfaces;

namespace Adapter.Implementations
{
    public class Car : ITransportFunction
    {
        public void Transport()
        {
            Console.WriteLine("Car is moving");
        }
    }
}
