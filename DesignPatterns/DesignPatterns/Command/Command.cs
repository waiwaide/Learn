using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command
{
    abstract class Command
    {
        protected Receiver Receiver;

        protected Command(Receiver receiver)
        {
            this.Receiver = receiver;
        }

        abstract public void Execute();
    }
}
