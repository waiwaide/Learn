﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory
{
    class FerrariCarFactory
    {
        public CarAbstract Product()
        {
            return new Ferrari();
        }
    }
}
