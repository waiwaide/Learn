using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
   public class Mocha:CondimentDecorator
    {
        
        public Mocha(BeverageComponent beverage):base(beverage)
        {
           
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ",Mocha";
        }
        public override double Cost()
        {
            return .20 + beverage.Cost();
        }        

    }
}
