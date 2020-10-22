﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Facade
{
    class Screen
    {
        internal void Open()
        {
            Console.WriteLine("打开屏幕");
        }
        internal void Close()
        {
            Console.WriteLine("关闭屏幕");
        }
    }
}
