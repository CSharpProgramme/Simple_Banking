using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking
{
    internal class Account
    {
        //ATTRIBUTES
        private string accNumber;
        private decimal accBalance;
        private string lastName;
        private string firstName;

        //CONSTRUCTOR
        public Account(string accNumber, decimal accBalance, string lastName, string firstName)
        {
            AccNumber = accNumber;
            AccBalance = accBalance;
            LastName = lastName;
            FirstName = firstName;
        }

        //GETTERS AND SETTERS
        public string AccNumber
        {
            get { return accNumber; }
            set { accNumber = value; }
        }
        public decimal AccBalance
        {
            get { return accBalance; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Account initial balance amount should be a positive value.");
                    accBalance = 0;
                }
                else
                {
                    accBalance = value;
                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        //METHODS
        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
            {
                AccBalance += amount;
            }
            else
            {
                Console.WriteLine("Cannot deposit a negative number");
            }
        }

        public virtual bool Debit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Cannot withdraw a negative number");
                return false;
            }

            if (amount > AccBalance)
            {
                Console.WriteLine("Debit amount exceeded account balance");
                return false;
            }
            else
            {
                AccBalance -= amount;
                Console.WriteLine("Money withdrawn successfully");
                return true;
            }
        }

        public virtual void DisplayAccount()
        {
            drawLine();
            Console.WriteLine($"| {"Account",38}  {"|",29}");
            drawLine();
            Console.WriteLine($"| {"Account number",-15} | {AccNumber,49} |");
            drawLine();
            Console.WriteLine($"| {"Balance Amount",-15} | {AccBalance,49:C} |");
            drawLine();
            Console.WriteLine($"| {"Last Name",-15} | {LastName,-49} |");
            drawLine();
            Console.WriteLine($"| {"First Name",-15} | {FirstName,-49} |");
            drawLine();
        }

        public virtual void drawLine()
        {
            Console.Write("|");
            for (int i = 0; i < 69; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("|");
        }
    }
}
