using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.state
{
    abstract class State
    {
        internal abstract void Handle(Context context);
    }
}
