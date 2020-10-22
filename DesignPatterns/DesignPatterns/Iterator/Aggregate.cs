using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Iterator
{
    abstract class Aggregate
    {
        internal abstract Iterator CreatIterator();
    }
}
