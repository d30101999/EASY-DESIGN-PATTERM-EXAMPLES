using System;
using System.Collections.Generic;
using System.Text;
using Decorator_Example.MilkTeas;
namespace Decorator_Example.DecoratorMT
{
    public class EggPudding : MilkTeaDecorator
    {
        public EggPudding(IMilkTea innerMilkTea) : base(innerMilkTea)
        {

        }

        public override double Cost()
        {
            return 3d + base.Cost();
        }
    }
}
