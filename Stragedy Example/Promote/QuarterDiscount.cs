using System;
using System.Collections.Generic;
using System.Text;

namespace Stragedy_Example.Promote
{
    public class QuarterDiscount : IPromoteStragedy
    {
        public double DoDiscount(double price)
        {
            return(price*0.75);
        }
    }
}
