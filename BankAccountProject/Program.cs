using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Client myClient = new Client("Kimmy Schmitt", "900 Public Square Blvd.\nCleveland, Ohio 44106", "440-885-8858");
            

            Checking myChecking = new Checking(5000d);
            Savings mySaving = new Savings(15000d);
            
            

            int selectedOption;
            string balanceOptSelected;
            string depositOptSelected;
            string withdrawOptSelected;


            do
            {

                Console.WriteLine("\n Welcome Kimmy! ");
                Console.WriteLine();
                Console.WriteLine("Please select an option");
                Console.WriteLine();
                Console.WriteLine("1. View Client Information");
                Console.WriteLine();
                Console.WriteLine("2. View Balance " );
                Console.WriteLine();
                Console.WriteLine("3. Deposit Funds (Incraments of $20.00 Only) ");
                Console.WriteLine();
                Console.WriteLine("4. Withdraw Funds (Incraments of $20.00 Only) ") ;
                Console.WriteLine();
                Console.WriteLine("5. Exit ");
                Console.WriteLine();
                


                //you then want to prompt user to select checkings or savings 


                //you then want to prompt user to select which account you want to deposit funds, checking or savings


                //you then want to prompt user to select which account they want to withdraw from, checkin or savings. 


                
                selectedOption = int.Parse(Console.ReadLine());

                switch (selectedOption)
                {
                    case 1:
                        myClient.ViewClientInfo();
                        
                        
                        break;

                    case 2:
                        Console.WriteLine("A. Checking " + "\n");
                       
                        Console.WriteLine("B. Savings " + "\n");
                        balanceOptSelected = Console.ReadLine().ToUpper();

                        if (balanceOptSelected == "A")
                        {
                            myChecking.ViewAccountNumber();
                            myChecking.ViewBalance();
                            
                        }
                        else if (balanceOptSelected =="B") 
                        {
                            mySaving.ViewAccountNumber();
                            mySaving.ViewBalance();
                        
                        }
                        else
                        {
                            Console.WriteLine("Invalid option selected");

                        }
                        break;

                    case 3:
                        Console.WriteLine("A. Checking " + "\n");

                        Console.WriteLine("B. Savings " + "\n");
                        depositOptSelected = Console.ReadLine().ToUpper();

                        if (depositOptSelected == "A")
                        {
                            myChecking.ViewAccountNumber();
                            myChecking.DepositMoney();
                        }

                        else if (depositOptSelected == "B")
                        {
                            mySaving.ViewAccountNumber();
                            mySaving.DepositMoney();
                        }
                        else
                        {
                            Console.WriteLine("Invalid options selected");
                        }

                        break;
                    case 4:
                        Console.WriteLine("A. Checking " + "\n");
                        
                        Console.WriteLine("B. Savings " + "\n");
                        withdrawOptSelected = Console.ReadLine().ToUpper();

                        if (withdrawOptSelected == "A")
                        {
                            myChecking.ViewAccountNumber();
                            myChecking.WithdrawMoney();
                            
                        }
                        else if (withdrawOptSelected == "B")
                        {
                            mySaving.ViewAccountNumber();
                            mySaving.WithdrawMoney();
                        }

                       
                        break;


                    case 5:
                        Console.WriteLine("Thank you for banking with us! ");
                        break;




                    default:
                        Console.WriteLine("Invalid option selected");
                        break;


                }

               } while ((selectedOption != 5));

        


        }
    }
}
