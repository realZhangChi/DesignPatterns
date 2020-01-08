using System;
using Duck.FlyBehavior;
using Duck.QuackBehavior;

namespace Duck.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new RealQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I’m a real Mallard duck");
        }
    }
}