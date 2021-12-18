using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Example.MilkTeas
{
    public class MilkTea : IMilkTea
    {
        public double Cost()
        {
            return 10d;
        }
    }
}
