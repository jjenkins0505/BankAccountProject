using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
 public abstract class Account 
    {
        //These are my fields 
        protected string accountNumber;
        protected double accountBalance;
        protected string accountType;
        protected double moneyDeposit;
        protected double moneyWithdraw;


        //these are my constructors 

        public Account(string accountNumber, double accountBalance, string accountType, double moneyDeposit, double moneyWithdraw)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.accountType = accountType;
            this.moneyDeposit = moneyDeposit;
            this.moneyWithdraw = moneyWithdraw;
                  
        }

        //properties


        public string AccountNumber
        {
            get {return this.AccountNumber; }
            set { this.accountNumber = "115969670"; }
        }

        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = 20000d; }
        }

        public string AccountType
        {
            get { return this.accountType; }
        }

        public double MoneyDeposit
        {
            get {return this.moneyDeposit; }
        }

        public double MoneyWithdraw
        {
            get { return this.moneyWithdraw; }
        }

        //methods 
        public virtual void ViewAccountNumber()

        {
        }    
      
        public virtual void ViewBalance()
        {
            Console.WriteLine("Your current total balance is: " + accountBalance);
        }
      
        public virtual void DepositMoney()
        {
            accountBalance += moneyDeposit ;
            Console.WriteLine(moneyDeposit);
        }

        public virtual void WithdrawMoney()
        {
            accountBalance -= moneyWithdraw;
            Console.WriteLine(moneyWithdraw);
        }

        public Account()
        {

        }
        
        
            
        
        
        

       


    }
}
