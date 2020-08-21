using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{

    class BankAccountEntitie
    {


        private int _accountID;
        private string _accountHolder;
        private double _balance;
        //Constructor - parameterized to initialize properties in new Bank Account object and enable short syntax for creating new objects
        public BankAccountEntitie(int AccountID, string AccountHolder, double Balance)
        {
            this.AccountID = AccounID;
            this.AccountHolder = AccountHolder;
            this.Balance = Balance;
        }
        //Constructor - for new objects with no parameters passed
        public BankAccountEntitie()
        { }

        public int AccountID
        {
            set
            {
                _accountID = value;
            }
            get
            {
                return _accountID;
            }

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
        //Setter with validation code to ensure no balance of less than zero is entered
        public double Balance
        {
            set
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