using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory
{
    class Benz : CarAbstract
    {
        public override void Print()
        {
            Console.WriteLine("I am Benz");
        }
    }
}
