//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

//Example input:

//program	            user
//Company name:     	Telerik Academy
//Company address:	    31 Al. Malinov, Sofia
//Phone number:     	+3598885555555
//Fax number:       	2
//Web site:	            http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	        25
//Manager phone:	    +3592981981

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Create your own company now!");

        Console.WriteLine("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.WriteLine("The addres of your company will be: ");
        string companyAddres = Console.ReadLine();

        Console.WriteLine("Enter phone number for contacts: ");
        string companyPhone = Console.ReadLine();

        Console.WriteLine("Enter your fax number: ");
        string companyFax = Console.ReadLine();

        Console.WriteLine("Enter your web site: ");
        string companyWebSite = Console.ReadLine();

        Console.WriteLine("Enter managersn first name");
        string managerFirstName = Console.ReadLine();

        Console.WriteLine("And managers last name: ");
        string managerLastName = Console.ReadLine();

        Console.WriteLine("Enter managers age: ");
        int managerAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Managers phone number is: ");
        long managerPhoneNumber = long.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Congratulations! You just created your own company!");
        Console.WriteLine("{0}\nAdress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})",
            companyName, companyAddres, companyPhone, companyFax, companyWebSite, managerFirstName, managerLastName, managerAge, managerPhoneNumber);

    }
}
