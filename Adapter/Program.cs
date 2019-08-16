using System;
using System.IO;
using Adapter.Implementations;
using Adapter.Interfaces;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //This pattern allows us to adapte one class to interface of another class without changing of adapteed class (we only can change the description of the methods and casting I/O parameters to the disered form
            //If we have class with needed features but it doesn't support desired interface we should follow this designed pattern



            //Imagine if we have Driver that can move by every transport that implements ITronsportFunction interface(basically we moving by car) , but we encountered situation where 
            //we need to take off car and sit on elk cause we want to get through the mountines, we have elk but he doesn't support our desired interface so we can't move by him currently now , 
            //but we can try to adapte elk to the car


            var driver = new ClientDriver();
            ITransportFunction car   = new Car();
            driver.Drive(car);
            ITransportFunction elk = new ElkAdapter();
            driver.Drive(elk);
            Console.ReadLine();

        }
    }
}
