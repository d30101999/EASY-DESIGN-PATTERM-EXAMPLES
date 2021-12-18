using System;
using System.Collections.Generic;
using System.Text;

namespace Stragedy_Example.Promote
{
    ////Khong giam gia
    public class NoDiscount : IPromoteStragedy
    {
        public double DoDiscount(double price)
        {
            return (price * 1);
        }
    }
}
