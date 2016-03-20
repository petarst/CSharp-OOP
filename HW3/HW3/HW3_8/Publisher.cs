

namespace HW3_8
{
    using System;
    using System.Threading;

    public delegate void TmeElapsetEventHandler (object sender, Publisher e);

    public class Publisher : EventArgs
    {
        public event EventHandler RaiseTimerEvent;

        public void Start(int ticks, int interval)
        {
            int start = 0;
            while (start<= interval)
            {
                Thread.Sleep(start * 1000);
                start += ticks;
                OnRaiseTImerEvent();
            }
        }
        protected void OnRaiseTImerEvent()
        {
            EventHandler e = RaiseTimerEvent;
            if (e!=null)
            {
                e(this, null);
            }
        }
    }
}
