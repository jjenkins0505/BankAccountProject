using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Client
    {

        //These are my Fields 

        protected string clientName;
        protected string clientAddress;
        protected string clientPhoneNumber;
        


        //Here are my Properties

        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = "Kimmy Schmitt"; }
        }

        public string ClientAddress
        {
            get { return this.clientAddress; }
            set { this.clientAddress = "900 Public Square Blvd.\nCleveland, Ohio 44106"; }
        }

        public string ClientPhoneNumber
        {
            get { return this.clientPhoneNumber; }
            set { this.clientPhoneNumber = "440-885-8858"; }
        } 
      

        

        //This is my constructor 
        public Client(string clientName, string clientAddress, string clientPhoneNumber)
        {
            this.clientName = clientName;
            this.clientAddress = clientAddress;
            this.clientPhoneNumber = clientPhoneNumber;
        
        }

        //This is my method

        public void  ViewClientInfo()
        {
            Console.WriteLine( clientName + "\n" + clientAddress + "\n" + clientPhoneNumber + "\n");
        }


    }
}
