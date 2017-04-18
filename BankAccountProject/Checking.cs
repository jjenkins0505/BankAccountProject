using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Checking : Account

    {
        //fields
        protected double checkBalance;
        protected string checkAccountNumber;
       
        


        //cosntructor
        public Checking(double checkBalance, string accountNumber, double accountBalance, string accountType, string checkAccountNumber)
        {
            this.checkBalance = checkBalance;
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.accountType = accountType;
            
           
        }

        public Checking (double checkBalance)
        {
            this.checkBalance = checkBalance;
            
        }


        //properties

        public double CheckBalance
        {
            get { return this.checkBalance; }
            set { this.checkBalance = 5000d; }
           
        }

        public string CheckAccountNumber
        {
           get { return this.checkAccountNumber; }
            set {this.checkAccountNumber = "4848450949"; }
        }

        //methods 

        public override void ViewBalance()
        {
            Console.WriteLine("Your Checking Account Balance is: " +"$" + checkBalance + "\n");
        }


        public override void DepositMoney()
        {
            this.checkBalance = checkBalance + 20;
            Console.WriteLine("Your new Savings Account Balance is: " + "$" + checkBalance + "\n");

        }

        public override void WithdrawMoney()
        {
            this.checkBalance = checkBalance - 20;
            Console.WriteLine("You new Checking Account Balance is: " + "$" + checkBalance);
        }

        public override void ViewAccountNumber()
        {
            accountNumber = "34859904390";
            Console.WriteLine("Checking Account Number: " + accountNumber);
        }











    }
}
