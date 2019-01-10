using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new QuackAsNormarl();
        }
        public override void Display()
        {
            Console.WriteLine("Mallard Duck");
        }
    }
}
