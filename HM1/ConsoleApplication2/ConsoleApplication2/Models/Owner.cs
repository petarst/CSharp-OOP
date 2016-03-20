
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.MobilePhone

    using System;
{
    class Owner
    {
        private string owner;

        public Owner()
        {
            this.owner = null;
        }
        public Owner(string owner)
        {
            this.owner = owner;
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
    }
}
