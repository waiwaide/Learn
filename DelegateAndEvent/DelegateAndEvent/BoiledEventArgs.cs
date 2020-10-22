using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateAndEvent
{
    public delegate void BoiledEventHandler(Object sender, BoiledEventArgs e);
    // 定义BoiledEventArgs类，传递给Observer所感兴趣的信息
    public class BoiledEventArgs
    {
        public readonly int temperature;
        public BoiledEventArgs(int temperature)
        {
            this.temperature = temperature;
        }
    }
}
