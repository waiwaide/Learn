using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Adapter
{
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("This is a special request");
        }
    }
}
