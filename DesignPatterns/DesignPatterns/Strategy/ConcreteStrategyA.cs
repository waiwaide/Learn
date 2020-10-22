using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
    class ConcreteStrategyA : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Called ConcreteStrategyA.Algorithm()");
        }
    }
}
