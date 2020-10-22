using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Composite
{
    class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name)
            : base(name)
        {
        }

        internal override void Add(Component component)
        {
            children.Add(component);
        }

        internal override void Remove(Component component)
        {
            children.Remove(component);
        }

        internal override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
