using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command.Example
{
    class TVReceiver
    {
        public void Open()
        {
            Console.WriteLine("TV Is Opened");
        }

        public void Close()
        {
            Console.WriteLine("TV Is Closed");
        }

    }
}
