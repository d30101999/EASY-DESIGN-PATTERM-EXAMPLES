using System;
using Decorator_Example.DecoratorMT;
using Decorator_Example.MilkTeas;
namespace Decorator_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let make some Milk Tea!!");
            var firstMilkTea = new EggPudding(
                                    new FruitPudding(
                                        new BlackSurgar(
                                            new Bubble(
                                                new MilkTea()))));
            ////Cost of EggPuddingFruitPuddingBlackSurgarBubbleMilkTea 10 + 3 + 4 + 1 + 2 = 20 
            Console.WriteLine(firstMilkTea.Cost());
        }
    }
}
