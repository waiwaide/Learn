using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Template
{
    class ConcreteClassA : AbstractClass
    {
        internal override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation1");
        }

        internal override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation2");
        }
    }
}
