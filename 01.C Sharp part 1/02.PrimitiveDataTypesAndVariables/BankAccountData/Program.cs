//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank 
//account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("Enter your names for bank account information!");
        Console.WriteLine("Enter first name: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter middle name: ");
        string middleName = Console.ReadLine();

        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();

        decimal availableMoney = 38297810582.312M;
        string bankName = "JRB - Just a random bank";
        string IBAN = "BG84239084ST00123";
        long firstCreditCardNumber = 1234567890123456;
        long secondCreditCardNumber = 0123456789012345;
        long thirdCreditCardNumber = 9876543210987654;
        Console.WriteLine("Balance: {0} $\nBankname: {1} \nIBAN: {2} \nFirst credit card number: {3} \nSecond credit card number: {4} \nThird credit card number: {5}",
            availableMoney, bankName, IBAN, firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber);
    }
}