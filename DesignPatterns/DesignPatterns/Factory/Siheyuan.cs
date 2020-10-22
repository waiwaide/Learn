using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory
{
    class Siheyuan : HouseAbstract
    {
        public override void Print()
        {
            Console.WriteLine("四合院和法拉利更配呦");
        }
    }
}
