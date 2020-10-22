using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory
{
    class LamborghiniCarFactory
    {
        public CarAbstract Product()
        {
            return new Lamborghini();
        }
    }
}
