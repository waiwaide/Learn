using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
   public class HouseBlend:BeverageComponent
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        public override double Cost()
        {
            return .89;
        }
    }
}
