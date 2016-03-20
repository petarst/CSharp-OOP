namespace HW1Version2.Library
{
    using System;

    public class Display
    {
        private double size;
        private string numberOfColors;

        public double Size
        {
            get { return this.size; }
            set { this.size = value; } 
        }

        public string NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; } 
        }
    }
}
