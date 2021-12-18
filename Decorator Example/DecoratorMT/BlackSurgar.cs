using System;
using System.Collections.Generic;
using System.Text;
using Decorator_Example.MilkTeas;
namespace Decorator_Example.DecoratorMT
{
    public class BlackSurgar : MilkTeaDecorator
    {
        public BlackSurgar(IMilkTea innerMilkTea) : base(innerMilkTea)
        {

        }

        public override double Cost()
        {
            return 1d + base.Cost();
        }
    }
}
