﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Practical
{
    public class Divide : Operation
    {
        public override double GetResult()
        {
            return NumberA / NumberB;
        }
    }
}
