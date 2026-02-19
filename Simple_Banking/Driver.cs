using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking
{
    internal class Driver
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter account number: ");
            string accNum = Console.ReadLine();

            Console.WriteLine("Please enter account balance: ");
            decimal accBal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter last name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("Please enter first name: ");
            string fName = Console.ReadLine();

            Console.WriteLine("Please enter interest rate: ");
            decimal interestRate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter transaction fee: ");
            decimal transactionFee = decimal.Parse(Console.ReadLine());

            Account myAccount = new Account(accNum, accBal, lName, fName);
            Console.WriteLine("initial account details");
            myAccount.DisplayAccount();
            Console.WriteLine();

            //SAVING ACCOUNT
            SavingsAccount mySavingAccount = new SavingsAccount(accNum, accBal, lName, fName, interestRate);
            Console.WriteLine("=== Savings Account: Before Adding Interest ===");
            Console.WriteLine($"initial Balance: {mySavingAccount.AccBalance:C}");
            mySavingAccount.DisplayAccount();
            Console.WriteLine();

            decimal interest = mySavingAccount.CalculateInterest();
            mySavingAccount.Credit(interest);
            Console.WriteLine("=== Savings Account: After Adding Interest ===");
            Console.WriteLine($"After adding interest: {mySavingAccount.AccBalance:C}");
            mySavingAccount.DisplayAccount();
            Console.WriteLine();

            //performing credit and debit operations
            Console.WriteLine("=== Savings Account: Before adding money into account ===");
            Console.WriteLine($"Initial Balance: {mySavingAccount.AccBalance:C}");
            Console.WriteLine();
            
            Console.WriteLine("=== Savings Account: After adding $200 into account ===");
            mySavingAccount.Credit(200m);
            Console.WriteLine($"New Balance: {mySavingAccount.AccBalance:C}");
            mySavingAccount.DisplayAccount();
            Console.WriteLine();


            Console.WriteLine("=== Savings Account: Before Removing money from account ===");
            Console.WriteLine($"Initial Balance: {mySavingAccount.AccBalance:C}");
            Console.WriteLine();

            Console.WriteLine("=== Savings Account: After Removing $300 from account ===");
            mySavingAccount.Debit(300m);
            Console.WriteLine($"New Balance: {mySavingAccount.AccBalance:C}");
            mySavingAccount.DisplayAccount();
            Console.WriteLine();
            
            
            //CHECKING ACCOUNT
            CheckingAccount myCheckingAmount = new CheckingAccount(accNum, accBal, lName, fName, transactionFee);
            Console.WriteLine("=== Checking Account: Before Credit Transaction ===");
            Console.WriteLine($"Initial Balance: {myCheckingAmount.AccBalance:C}");
            myCheckingAmount.DisplayAccount();
            Console.WriteLine();


            Console.WriteLine("=== Checking Account: After Credit Transaction ===");
            myCheckingAmount.Credit(300m);//adding money
            Console.WriteLine($"New Balance: {myCheckingAmount.AccBalance:C}");
            myCheckingAmount.DisplayAccount();
            Console.WriteLine();

            Console.WriteLine("=== Checking Account: Before Debit Transaction ===");
            Console.WriteLine($"Initial Balance: {myCheckingAmount.AccBalance:C}");
            Console.WriteLine();

            Console.WriteLine("=== Checking Account: After Debit Transaction ===");
            myCheckingAmount.Debit(200m);//withdraw money
            Console.WriteLine($"New Balance: {myCheckingAmount.AccBalance:C}");
            myCheckingAmount.DisplayAccount();
            Console.WriteLine();
        }
    }
}
