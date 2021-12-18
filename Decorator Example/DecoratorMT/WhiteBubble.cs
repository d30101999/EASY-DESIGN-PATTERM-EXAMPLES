using System;
using System.Collections.Generic;
using System.Text;
using Decorator_Example.MilkTeas;
namespace Decorator_Example.DecoratorMT
{
    public class WhiteBubble : MilkTeaDecorator
    {
        public WhiteBubble(IMilkTea innerMilkTea) : base(innerMilkTea)
        {

        }

        public override double Cost()
        {
            return 5d + base.Cost();
        }
    }
}
