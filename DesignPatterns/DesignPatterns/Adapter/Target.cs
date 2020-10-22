using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Adapter
{
    class Target
    {
        internal virtual void Request()
        {
            Console.WriteLine("This is a common request");
        }
    }
}
