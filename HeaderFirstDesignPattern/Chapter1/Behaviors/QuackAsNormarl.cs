﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public class QuackAsNormarl:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack gua gua gua");
        }
    }
}
