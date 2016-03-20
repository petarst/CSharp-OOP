
namespace HW5_2.Model
{
    using System;

    public class InvalidRangeException <T> : ApplicationException
    {
        private T startRange;
        private T endRange;

        public InvalidRangeException(string msg, T start, T end, Exception innerEx)
            :base (msg,innerEx)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }

        public InvalidRangeException(string msg, T start, T end)
            : this(msg, start,end, null)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }

        public T EndRange
        {
            get { return this.endRange; }
            private set { this.endRange = value; }
        }
        


        public T StartRange
        {
            get { return this.startRange; }
            private set { this.startRange = value; }
        }
        
    }
}
