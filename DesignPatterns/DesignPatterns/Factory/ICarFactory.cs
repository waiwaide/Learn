using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory
{
    interface ICarFactory
    {
         CarAbstract Product();
    }
}
