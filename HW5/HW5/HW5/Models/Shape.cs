using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW5.Models
{
    public abstract class Shape
    {
        private double width;

        private double height;

        public Shape(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get { return this.height; }
            private set 
            {
                if (value <=0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be negative number or zero");
                }
                
                this.height = value; 
            
            }
        }
        

        public double Width
        {
            get { return this.width; }
            private set 
            {
                if (value <=0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be negative number or zero");
                }
                
                this.width = value; 
            }
        }

        public abstract double CalculateSurface();        
    }
}
