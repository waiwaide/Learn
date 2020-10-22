using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Facade
{
    class Amplifier
    {
        internal void Open()
        {
            Console.WriteLine("打开功放机");
        }
        internal void Close()
        {
            Console.WriteLine("关闭功放机");
        }
    }
}
