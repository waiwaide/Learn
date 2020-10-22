using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Composite
{
   abstract class Component
    {
        protected string name;
        internal Component(string name)
        {
            this.name = name;
        }
        internal abstract void Add(Component component);
        internal abstract void Remove(Component component);
        internal abstract void Display(int depth);
    }
}
