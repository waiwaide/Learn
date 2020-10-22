using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory
{
    class HouseAndCar : ISuperFactory
    {
        public ICarFactory carInit()
        {
            return new BenzCarFactory();
        }

        public IHouseFactory houseInit()
        {
            return new SiheyuanHouseFactory();
        }
    }
}
