using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Factory.Implementations;

namespace Patterns.Factory
{
    class Program
    {
        //Factory pattern defines base interface for creating objects of some class, but creating of the objects is delegated to inherited classes
        //USING : In case if we dont know how many products will be, and we temporary should to extend our app.
        static void Main(string[] args)
        {
            //Declare a creator
            var creator = new TelegramMessageCreator();
            var message = creator.CreateMessage("message", "from", "to");
            message.Send();
        }
    }
}
