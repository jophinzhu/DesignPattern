﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public class FlyNoWay:IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Cannot Fly");
        }
    }
}
