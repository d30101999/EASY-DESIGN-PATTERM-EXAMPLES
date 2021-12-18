using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Example.MilkTeas
{
    public abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea milkTea;
        public IMilkTea MilkTea { get => milkTea; set => milkTea = value; }
        protected MilkTeaDecorator(IMilkTea innerMilkTea)
        {
            MilkTea = innerMilkTea;
        }
        public virtual double Cost()
        {
            return MilkTea.Cost();
        }
    }
}
