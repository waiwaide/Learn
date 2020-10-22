using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory
{
    class VillaHouseFactory:IHouseFactory
    {
        public HouseAbstract Product()
        {
            return new Villa();
        }
    }
}
