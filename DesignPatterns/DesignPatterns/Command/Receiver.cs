﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command
{
    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action");
        }
    }
}
