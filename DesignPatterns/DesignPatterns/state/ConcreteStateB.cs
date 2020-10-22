using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.state
{
    class ConcreteStateB : State
    {
        internal override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
