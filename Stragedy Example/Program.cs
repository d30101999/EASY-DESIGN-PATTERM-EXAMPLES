using System;
using Stragedy_Example.Promote;
namespace Stragedy_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start getting ticket!!!!!");
            var random = new Random();
            for (var i = 1; i < 6; i++)
            {
                var stragedyIndex = random.Next(0, 3);
                var ticket = new Ticket();
                ticket.Name = "Ve so: " + (i);
                ticket.Price = 100;
                switch( stragedyIndex)
                {
                    case 0:
                        ticket.PromoteStragedy = new NoDiscount();
                        break;
                    case 1:
                        ticket.PromoteStragedy = new HalfDiscount();
                        break;
                    case 2:
                        ticket.PromoteStragedy = new QuarterDiscount();
                        break;
                }
                var promotedprice = ticket.PromotedPrice();
                Console.WriteLine("Prompted price of " + ticket.Name + " is " + promotedprice + " " + ticket.PromoteStragedy.GetType().Name);


                
            }
        }
    }
}
