using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
     public abstract class CondimentDecorator:BeverageComponent
    {
        public BeverageComponent beverage;

        public CondimentDecorator( BeverageComponent beverage)
        {
            this.beverage = beverage;
        }
       
    }
}
