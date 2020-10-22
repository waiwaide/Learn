using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace DesignPatterns.Iterator
{
    class ConcreteAggregate : Aggregate
    {
        private ArrayList items = new ArrayList();
        internal override Iterator CreatIterator()
        {
            return new ConcreteIterator(this);
        }

        internal int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
