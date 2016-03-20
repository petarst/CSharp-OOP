namespace _01.MobilePhone
    using System;
{
    
    class Price
    {
        private decimal price;

        public Price(decimal price)
        {
            this.price = price;
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

    }
}
