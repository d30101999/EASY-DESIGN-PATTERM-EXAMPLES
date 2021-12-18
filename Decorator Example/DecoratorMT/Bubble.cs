using System;
using System.Collections.Generic;
using System.Text;
using Decorator_Example.MilkTeas;
namespace Decorator_Example.DecoratorMT
{
    public class Bubble : MilkTeaDecorator
    {
        public Bubble(IMilkTea innerMilkTea) : base(innerMilkTea)
        {

        }

        public override double Cost()
        {
            return 2d + base.Cost();
        }
    }
}
