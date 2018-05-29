﻿using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-17 Overriding a virtual method
    /// </summary>
    class Base
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }

    class Derived : Base
    {
        public override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            Console.WriteLine(derived.MyMethod());
        }
    }
}
