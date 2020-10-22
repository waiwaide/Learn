using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Template
{
   abstract class AbstractClass
    {
        internal abstract void PrimitiveOperation1();
        internal abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }
}
