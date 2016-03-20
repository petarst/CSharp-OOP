namespace HW3_7
{   //Problem 7. Timer
    //Using delegates write a class Timer that can execute certain method at each t seconds.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    
    public delegate void RepeatDelegate (int t);
    
    public class Test
    {
        static void Main()
        {
            RepeatDelegate t = delegate(int time)
            {
                while (true)
                {
                    Thread.Sleep(time);
                    Console.WriteLine("{0}", DateTime.Now);

                }

            };
            t(1000);
        }
    }
}
