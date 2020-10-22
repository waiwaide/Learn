using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Proxy
{
    class ConcreteSubject : Subject
    {
        internal override void Request()
        {
            Console.WriteLine("Called ConcreteSubject");
        }
    }
}
