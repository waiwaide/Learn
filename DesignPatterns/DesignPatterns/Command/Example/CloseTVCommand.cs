using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command.Example
{
    class CloseTVCommand : ICommand
    {
        private TVReceiver tVInvoker =new TVReceiver();
        internal CloseTVCommand(TVReceiver tVInvoker)
        {
            this.tVInvoker = tVInvoker;
        }
        public void Execute()
        {
            tVInvoker.Close();
        }
    }
}
