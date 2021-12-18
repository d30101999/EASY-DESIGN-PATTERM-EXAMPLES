using System;
using System.Collections.Generic;
using System.Text;
using Stragedy_Example.Promote;
namespace Stragedy_Example
{
    public class Ticket
    {
        private IPromoteStragedy promoteStragedy;
        private double price;
        private string name;
        public IPromoteStragedy PromoteStragedy { get => promoteStragedy; set => promoteStragedy = value; }
        public double Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }

        public Ticket()
        { }
        public Ticket(IPromoteStragedy promoteStragedy)
        {
            PromoteStragedy = promoteStragedy;
        }
        public double PromotedPrice()
        {
            return PromoteStragedy.DoDiscount(Price);
        }
    }
}
