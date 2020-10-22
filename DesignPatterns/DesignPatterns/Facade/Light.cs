using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Facade
{
    class Light
    {
        internal void Open()
        {
            Console.WriteLine("打开灯光");
        }
        internal void Close()
        {
            Console.WriteLine("关闭灯光");
        }
    }
}
