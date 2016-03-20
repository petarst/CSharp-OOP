
namespace HW5.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Rectanlge : Shape
    {
        public Rectanlge(double height, double width)
            :base(height,width )
        {

        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }

    }
}
