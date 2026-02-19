using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking
{
    internal class CheckingAccount : Account
    {
        //ATTRIBUTE
        private decimal transactionFee;

        //CONTSTRUCTOR
        public CheckingAccount(string accNumber, decimal accBalance, string lastName, string firstName, decimal transactionFee) :
            base(accNumber, accBalance, lastName, firstName) 
        {
            TransactionFee = transactionFee;
        }

        //GETTERS AND SETTERS
        public decimal TransactionFee
        {
            get { return transactionFee; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Transaction fee should be a positive value.");
                    transactionFee = 1.5m;
                }
                else
                {
                    transactionFee = value;
                }
            }
        }

        //METHODS
        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            AccBalance -= TransactionFee;
        }

        public override bool Debit(decimal amount)
        {
            bool withdrawSuccess = base.Debit(amount + TransactionFee);

            if (withdrawSuccess) 
            {
                Console.WriteLine("Withdraw successfull! A Transaction fee is charged");
            }
            else
            {
                Console.WriteLine("Withdraw Transaction is not successfull!");
            }
                return withdrawSuccess;
        }

        public override void DisplayAccount()
        {
            drawLine();
            Console.WriteLine($"| {"Checking Account",38}  {"|",29}");
            drawLine();
            Console.WriteLine($"| {"Account number",-15} | {AccNumber,49} |");
            drawLine();
            Console.WriteLine($"| {"Balance Amount",-15} | {AccBalance,49:C} |");
            drawLine();
            Console.WriteLine($"| {"Last Name",-15} | {LastName,-49} |");
            drawLine();
            Console.WriteLine($"| {"First Name",-15} | {FirstName,-49} |");
            drawLine();
            Console.WriteLine($"| {"Transaction fee",-15} | {TransactionFee,49:C} |");
            drawLine();
        }

        public override void drawLine()
        {
            base.drawLine();
        }
    }
}
