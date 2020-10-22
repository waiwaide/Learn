using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Iterator
{
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current =0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
 

        internal override object CurrentItem()
        {
            return aggregate[current];
        }

        internal override object First()
        {
            return aggregate[0];
        }

        internal override bool IsDone()
        {
            return current >= aggregate.Count;
        }

        internal override object Next()
        {
            object ret = null;
            if (current < aggregate.Count - 1)
            {
                ret = aggregate[++current];
            }
            return ret;
        }
    }
}
