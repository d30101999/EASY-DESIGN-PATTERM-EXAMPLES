using System;
using System.Collections.Generic;
using System.Text;
using Decorator_Example.MilkTeas;
namespace Decorator_Example.DecoratorMT
{
    public class FruitPudding : MilkTeaDecorator
    {
        public FruitPudding(IMilkTea innerMilkTea) : base(innerMilkTea)
        {

        }

        public override double Cost()
        {
            return 4d + base.Cost();
        }
    }
}
