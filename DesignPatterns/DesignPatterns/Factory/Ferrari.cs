using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory
{
    class Ferrari:CarAbstract
    {
        public override void Print()
        {
            Console.WriteLine("Ferrari");
        }
    }
}
