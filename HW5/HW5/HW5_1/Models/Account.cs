using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW5_1.Models
{
    public abstract class Account
    {
        private Customer customers;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customers, decimal balance, decimal interestRate)
        {
            this.Customers = customers;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customers 
        {
            get { return this.customers; }
            private set {this.customers = value; } 
        }

        public decimal Balance 
        {
            get { return this.balance; }
            protected set 
            {
                if (value <0)
                {
                    throw new ArgumentException("Balance cannot be a negative");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate 
        {
            get { return this.interestRate; }
            private set 
            {
                if (value <0)
                {
                    throw new ArgumentException("Interest must be a positive number");
                }

                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterestAmount(int numOfMonths)

        {
            if (numOfMonths<0)
            {
                throw new ArgumentException("Number of months must be a positive number");
            }

            return numOfMonths * this.InterestRate;
        }

    }
}
