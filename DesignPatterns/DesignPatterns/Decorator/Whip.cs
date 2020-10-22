using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
      public  class Whip : CondimentDecorator
    {
        
        public Whip(BeverageComponent beverage):base(beverage)
        {
            
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ",Whip";
        }
        public override double Cost()
        {
            return .15 + beverage.Cost();
        }
    }
}
