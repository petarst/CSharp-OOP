namespace HW3_8
{
    using System;
    using System.Threading;

    public class Handler
    {
        public Handler(Publisher pub)
        {
            pub.RaiseTimerEvent += HandleTimerEvent;
        }

        public static void HandleTimerEvent(object sender, EventArgs args)
        {
            Console.WriteLine("Event Raised: {0}",DateTime.Now);
        }

    }
}
