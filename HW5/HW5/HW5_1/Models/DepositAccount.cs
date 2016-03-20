using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HW5_1.Inteface;

namespace HW5_1.Models
{
    public class DepositAccount : Account, IDepositable, IWithdrawAmmount
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate):
            base (customer, balance, interestRate)
        {

        }

        public void DepositAmmount(decimal ammount)
        {
            this.Balance += ammount;
        }

        public void WithdrawAmount(decimal amount)
        {
            if (amount>this.Balance)
            {
                throw new ArgumentException("Amount is higher than balance in the account ");
            }

            this.Balance -= amount;
        }

        public override decimal CalculateInterestAmount(int numOfMonths)
        {
            if (this.Balance >0 && this.Balance <1000)
            {
                throw new ArgumentException("Interest ammount cannot be calculated with positive balance less than 1000");
            }

            return base.CalculateInterestAmount(numOfMonths);
        }
    }
}
