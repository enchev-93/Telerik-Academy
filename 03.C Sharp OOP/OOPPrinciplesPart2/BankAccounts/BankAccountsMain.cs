namespace BankAccounts
{
    using System;

    public class BankAccountsMain
    {
        public static void Main()
        {
            IndividualCustomer pesho = new IndividualCustomer("Pesho");
            CompanyCustomer telerik = new CompanyCustomer("Telerik");

            LoanAccount loanAcc = new LoanAccount(pesho, 250, 25);
            DepositAccount depositeAcc = new DepositAccount(telerik, 10000, 20);

            loanAcc.DepositAmount(100);
            Console.WriteLine(loanAcc.Balance);

            depositeAcc.WithdrawAmount(5000);
            Console.WriteLine(depositeAcc.Balance);

            Console.WriteLine(depositeAcc.CalculateInterestAmount(12));
        }
    }
}
