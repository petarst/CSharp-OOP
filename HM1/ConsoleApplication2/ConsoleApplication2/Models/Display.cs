using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.MobilePhone
{
    class Display
    {
        private decimal? size;
        private ulong? colors;

        public Display()
        {
            this.size = null;
            this.colors = null;
        }
        public Display(decimal size)
            :this()
        {
            this.size = size;
        }
        public Display(decimal size, ulong colors)
            :this(size)
        {
            this.colors = colors;
        }

        public decimal? Size 
        {
            get { return this.size; }

            set {
                    if (value == null || value>0)
                    {
                    this.size = value;
                    }
                    else
                    {
                    throw new ArgumentException("Please, insert positive number!");
                    }

                }
        }

        public ulong? Colors 
        {
            get { return this.colors; }
            set
            {
                if (value==null || value > 0)
                {
                    this.colors = value;
                }
                else
                {
                    throw new ArgumentException("Please, insert positive number!");
                }
            }
        }
    }
}
