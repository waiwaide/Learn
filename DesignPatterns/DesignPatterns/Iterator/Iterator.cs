using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Iterator
{
    abstract class Iterator
    {
        internal abstract object First();
        internal abstract object Next();
        internal abstract bool IsDone();
        internal abstract object CurrentItem();
    }
}
