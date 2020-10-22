using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Adapter
{
    class Adapter:Target
    {
        private Adaptee adaptee = new Adaptee();

        internal override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
