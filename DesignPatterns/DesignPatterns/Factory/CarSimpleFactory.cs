using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory
{
   public class CarSimpleFactory
    {
        public CarAbstract Product(string type)
        {
            CarAbstract car = null;
            switch (type)
            {
                case"Benz":
                    car = new Benz();
;                    break;
                case "Ferrari":
                    car = new Ferrari();
                    break;
                case "Lamborghini":
                    car = new Lamborghini();
                    break;

            }
            return car;

        }

    }
}
