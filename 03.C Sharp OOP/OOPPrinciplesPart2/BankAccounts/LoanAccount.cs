namespace BankAccounts
{
    using System;
    using System.Linq;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void DepositAmount(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterestAmount(int numOfMonths)
        {
            if (numOfMonths < 0)
            {
                throw new ArgumentException("Number of months can not be negative.");
            }
            if (this.Customer is CompanyCustomer)
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
