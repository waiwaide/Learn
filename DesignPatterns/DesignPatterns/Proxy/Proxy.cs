using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Proxy
{
    class Proxy : Subject
    {
        private ConcreteSubject concreteSubject;
        internal override void Request()
        {
            if (concreteSubject == null)
            {
                concreteSubject = new ConcreteSubject();
            }
            concreteSubject.Request();
        }
    }
}
