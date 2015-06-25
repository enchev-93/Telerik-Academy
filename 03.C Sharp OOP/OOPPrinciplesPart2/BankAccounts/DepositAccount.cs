namespace BankAccounts
{
    using System;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void DepositAmount(decimal amount)
        {
            this.Balance += amount;
        }

        public void WithdrawAmount(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("Amount is higher than balance in the account.");
            }

            this.Balance -= amount;
        }

        public override decimal CalculateInterestAmount(int numOfMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                throw new ArgumentException("Interest amount can not be calculated with positive balance less than 1000.");
            }

            return base.CalculateInterestAmount(numOfMonths);
        }
    }
}
