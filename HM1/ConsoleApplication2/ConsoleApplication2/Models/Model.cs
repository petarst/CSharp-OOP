using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.MobilePhone
{
    class Model
    {
        private string models;

        public Model()
        {
            this.models = null;
        }
        public Model(string models)
        {
            this.models = models;
        }

        public string Models 
        {
            get { return this.models; }
            set
            {
                if (value==null || value.Length > 0)
                {
                    this.models = value; 
                }
            }
        }

        

    }
}
