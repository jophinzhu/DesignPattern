using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// Brain power of Chapter 1
    /// </summary>
    public class DuckCall
    {
        IQuackBehavior iQuackBehavior;
        public DuckCall()
        {
            iQuackBehavior = new QuackAsEletricity();
        }
        public void Display()
        {
            Console.WriteLine("This is an electic duck");
        }
        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            iQuackBehavior = quackBehavior;
        }
        public void PerformQuack()
        {
            iQuackBehavior.Quack();
        }
    }
}
