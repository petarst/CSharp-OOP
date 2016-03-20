using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HW5_1.Inteface;

namespace HW5_1.Models
{
    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base (customer, balance, interestRate)
        {

        }
        public void DepositAmmount(decimal ammount)

        {
            this.Balance += ammount;
        }

        public override decimal CalculateInterestAmount(int numOfMonths)
        {
            if (numOfMonths <0)
            {
                throw new ArgumentException("NumOfMonths cannot be a negative");
            }
            if (this.Customers is IndividualCustomer)
            {
                numOfMonths -= 3;
            }
            else if (this.Customers is CompanyCustomer)
            {
                numOfMonths -= 2;
            }
            if (numOfMonths < 0)
            {
                return 0;
            }

            return numOfMonths * this.InterestRate;
        }
    }
}
