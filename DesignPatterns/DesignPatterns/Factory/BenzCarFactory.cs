using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory
{
    public class BenzCarFactory : ICarFactory
    {
        public CarAbstract Product( )
        {
            return new Benz();
        }
    }
}
