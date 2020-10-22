using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Espresso : BeverageComponent
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
