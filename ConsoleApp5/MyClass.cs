﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class MyClass : IMyInterface
    {
        public double MyGetPi()
        {
            return Math.PI;
        }
        public int MyGetInt() 
        {
            return 25;
        }
        public int MySquare(int x)
        {
            return (int)(x * x);
        }
        public double MySqrt(double x)
        {
            return (double)Math.Sqrt(x);
        }
    }
}
