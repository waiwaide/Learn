using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Facade
{
    class DVDPlayer
    { 

        internal void Open()
    {
        Console.WriteLine("打开DVD播放器");
    }
    internal void Close()
    {
        Console.WriteLine("关闭DVD播放器");
    }
}
}
