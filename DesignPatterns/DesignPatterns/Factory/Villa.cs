using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory
{
    class Villa : HouseAbstract
    {
        public override void Print()
        {
            Console.WriteLine("别墅和法拉利更配");
        }
    }
}
