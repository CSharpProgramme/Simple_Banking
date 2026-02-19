using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking
{
    internal class SavingsAccount : Account
    {
        //ATTRIBUTES
        private decimal interestRate;//in percentage

        //CONSTRUCTOR
        public SavingsAccount(string accNumber, decimal accBalance, string lastName, string firstName, decimal interestRate) :
            base(accNumber, accBalance, lastName, firstName)
        {
            InterestRate = interestRate;
        }

        //GETTERS AND SETTERS
        public decimal InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Interest rate should be a positive value.");
                    interestRate = 0.05m;
                }
                else
                {
                    interestRate = value/100;
                }
            }
        }

        //METHODS
        public override void Credit(decimal amount)
        {
            base.Credit(amount);
        }

        public override bool Debit(decimal amount)
        {
            return base.Debit(amount);
        }

        public decimal CalculateInterest()
        {
            return (AccBalance * InterestRate);
        }

        public override void DisplayAccount()
        {
            drawLine();
            Console.WriteLine($"| {"Savings Account",38}  {"|",29}");
            drawLine();
            Console.WriteLine($"| {"Account number",-15} | {AccNumber,49} |");
            drawLine();
            Console.WriteLine($"| {"Balance Amount",-15} | {AccBalance,49:C} |");
            drawLine();
            Console.WriteLine($"| {"Last Name",-15} | {LastName,-49} |");
            drawLine();
            Console.WriteLine($"| {"First Name",-15} | {FirstName,-49} |");
            drawLine();
            Console.WriteLine($"| {"Interest Rate",-15} | {InterestRate,49:P} |");
            drawLine();
            Console.WriteLine($"| {"Interest Amount",-15} | {CalculateInterest(),49:C} |");
            drawLine();
        }

        public override void drawLine()
        {
            base.drawLine();
        }

    }
}
