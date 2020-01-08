using System;
namespace Duck.QuackBehavior
{
    public class RealQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}