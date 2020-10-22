using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Template
{
    class ConcreteClassB:AbstractClass
    {
        internal override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation1");
        }

        internal override void PrimitiveOperation2()
        { 
            Console.WriteLine("ConcreteClassB.PrimitiveOperation2");
        }
    }
}
