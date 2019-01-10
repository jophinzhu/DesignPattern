using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter1;

namespace ConsoleAppTestForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            duck.PerformFly();
            duck.PerformQuack();
            Console.WriteLine("--------------");
            duck.SetFlyBehavior(new FlyNoWay());
            duck.SetQuackBehavior(new QuackAsSqueak());
            duck.PerformFly();
            duck.PerformQuack();
            Console.ReadKey();
        }
    }
}
