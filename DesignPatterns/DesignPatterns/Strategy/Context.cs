using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
    class Context
    {
        private IStrategy strategy;
        internal Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        internal void ContextAlgorithm()
        {
            strategy.Algorithm();
        }
    }
}
