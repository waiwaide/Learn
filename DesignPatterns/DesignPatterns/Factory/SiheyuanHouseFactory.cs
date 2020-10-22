using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory
{
    class SiheyuanHouseFactory : IHouseFactory
    {
        public HouseAbstract Product()
        {
            return new Siheyuan();
        }
    }
}
