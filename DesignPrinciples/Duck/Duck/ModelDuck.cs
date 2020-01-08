using System;
using Duck.FlyBehavior;
using Duck.QuackBehavior;

namespace Duck.Duck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new RealQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I’m a real Mallard duck");
        }
    }
}