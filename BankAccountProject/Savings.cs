using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Savings : Account
    {
        //fields

        protected double saveBalance;
        protected string saveAccountNumber;
        
        
        //constructor

        public Savings(double saveBalance, string accountNumber, double accountBalance, string accountType,string saveAccountNumber)
        {
            this.saveBalance = saveBalance;
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.accountType = accountType;
            this.saveAccountNumber = saveAccountNumber;
        }
        
        public Savings(double saveBalance)
        {
            this.saveBalance = saveBalance;
        }
        //properties

        public double SaveBalance
        {
            get { return this.saveBalance; }
            set { this.saveBalance = 15000d; }
        }


        //method

        public override void ViewBalance()
        {
            Console.WriteLine("Your Savings Account Balance is: " +"$" + saveBalance + "\n");
        }

        public override void DepositMoney()
        {
            this.saveBalance = saveBalance + 20;
            Console.WriteLine("Your new Savings Account Balance is: " + "$" + saveBalance + "\n");
        }

        public override void WithdrawMoney()
        {

           
            this.saveBalance = saveBalance - 20;
            Console.WriteLine("Your New Savings Account Balance is: " + "$" + saveBalance + "\n");
            if (saveBalance < 14800)
            {
                Console.WriteLine("XXXXXXXX You do not have enough funds availible XXXXXXXXXX ");
            }

            
        }

        public override void ViewAccountNumber()
        {
            saveAccountNumber = "59996968400";
            Console.WriteLine("Savings Account Number: " + saveAccountNumber);
        }

        
        
            
                


            
        





    }
}
