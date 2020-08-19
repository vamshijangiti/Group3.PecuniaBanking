using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{
   
        class BankAccount
        {               //Class declaration

            private int _accountNumber;         //Declare private properties
            private string _accountHolder;
            private double _balance;

            public BankAccount(int AccountNumber, string AccountHolder, double Balance) //Constructor - parameterized to initialize properties in new Bank Account object and enable short syntax for creating new objects
            {
                this.AccountNumber = AccountNumber;
                this.AccountHolder = AccountHolder;
                this.Balance = Balance;
            }

            public BankAccount()                     //Constructor - for new objects with no parameters passed
            {
            }

            public int AccountNumber
            {
            set
            {
                _accountNumber = value;
            }
            get
            { 
                return _accountNumber;
            }      //Auto-implemented Property - so we don't need full getter/setter syntax
              
            }
            public string AccountHolder
            {
            set
            {
                _accountHolder = value;
            }
            get 
            {
                return _accountHolder;
            }
             
            }
            public double Balance
            {
            set                                 //Setter with validation code to ensure no balance of less than zero is entered
            {
                if (value > 0)
                {
                    this._balance = value;
                }
                else
                {
                    this._balance = 0;
                }
            }
            get 
            {
                return _balance;
            }
                
            }
            
    

}
}
