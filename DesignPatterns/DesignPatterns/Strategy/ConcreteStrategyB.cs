using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
    class ConcreteStrategyB:IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Called ConcreteStrategyB.Algorithm()");
        }
    }
}
