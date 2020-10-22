using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command.Example
{
    class OpenTVCommand:ICommand
    {
        private TVReceiver tVInvoker = new TVReceiver();
        public OpenTVCommand(TVReceiver tVInvoker)
        {
            this.tVInvoker = tVInvoker;
        }
        public void Execute()
        {
            tVInvoker.Open();
        }
    }
}
