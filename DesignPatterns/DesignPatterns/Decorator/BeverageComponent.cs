using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
    public abstract class BeverageComponent
    {
        public String description = "Unknow Beverage";
        public virtual String GetDescription()
        {
            return description;
        }
       

        public  abstract double Cost();
    }
}
