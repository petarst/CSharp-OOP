﻿
//Problem 8.* Events
//Read in MSDN about the keyword event in C# and how to publish events.
//Re-implement the above using .NET events and following the best practices.
namespace HW3_8
{
    using System;
    using System.Threading;

    public class Test
    {
        static void Main()
        {
            Publisher pub = new Publisher();
            Handler hand = new Handler(pub);

            pub.Start(2, 10);
        }
    }
}
