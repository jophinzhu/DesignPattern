using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;
        public void Swim()
        {
            Console.WriteLine("Every duck can swim");
        }
        public void SetFlyBehavior(IFlyBehavior iFlyBehavior)
        {
            flyBehavior = iFlyBehavior;
        }
        public void SetQuackBehavior(IQuackBehavior iQuackBehavior)
        {
            quackBehavior = iQuackBehavior;
        }

        public abstract void Display();
        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        public void PerformQuack()
        {
            quackBehavior.Quack();
        }
    }
}
