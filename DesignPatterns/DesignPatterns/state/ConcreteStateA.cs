using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.state
{
    class ConcreteStateA:State
    {
        internal override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
