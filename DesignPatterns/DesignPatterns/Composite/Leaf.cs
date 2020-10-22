using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Composite
{
    class Leaf:Component
    {
        internal Leaf(string name) : base(name)
        {

        }
        internal override void Add(Component component)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        internal override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        internal override void Remove(Component component)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
    }
}
