using System;
using Duck.Duck;
using Duck.FlyBehavior;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallard = new MallardDuck();

            mallard.PerformQuack();
            mallard.PerformFly();

            var model = new ModelDuck();
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();
        }
    }
}
