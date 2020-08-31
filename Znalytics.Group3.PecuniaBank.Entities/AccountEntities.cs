//Entities Layer created by sriram 
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;

namespace Znalytics.Group3.PecuniaBank.AccountEntities
{
    /// <summary>
    /// Entity Layer for BankLayer
    /// </summary>
    interface IAccount
    {
        //fields
        int AccountId
        {
            set; get;
        }
        string DateOfCreation
        {
            set; get;
        }
        long Balance
        {
            set; get;
        }
    }
    public class SavingsAccount : IAccount
    {
        //private Fields

        /// <summary>
        /// <param name=AccountId></param>
        /// <param name=dateOfCreation>Date of creation</param>
        /// <param name=Balance>balance</param>
        /// </summary>
        private int _accountId;
        private string _dateOfCreation;
        private long _balance;


        public int AccountId
        {
            set
            {
                if (_accountId != 0)
                {
                    _accountId = value;//after validation accountid is assigned to value
                }
                else
                {
                    throw new ApplicationException("account id should not be zero or null ");//raises exception if accountid is nill or zero
                }

            }
            get
            {
                return _accountId;
            }
        }



        public string DateOfCreation
        {
            set
            {
                if (_dateOfCreation != null)
                {
                    _dateOfCreation = value;//after validation dateofcreation should be in dd:mm:yy format
                }
            }
            get
            {
                return _dateOfCreation;//dateofcreation 
            }
        }

        public long Balance
        {
            set
            {
                if (_balance >= 2500)//balance shouldnot be equal to zero
                {
                    _balance = value;//balance 
                }
                else
                {
                    throw new AccountException("your minimum balance should be maintained");
                }
            }
            get
            {
                return _balance;//returns balance
            }
        }



        public class CurrentAccount : IAccount
        {

            private int accId;
            private long _balance;
            private string _dateOfCreation;

            public CurrentAccount()
            {
            }

           /* public CurrentAccount(int accId, long balance, string dateOfCreation)
            {
                accId = accId;
                _balance = balance;
                _dateOfCreation = dateOfCreation;
            }*/

            public int AccountId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string DateOfCreation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public long Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
        public int AccId
        {
            set
            {
                if (_accountId != 0)
                {

                    _accountId = value;
                }

                else
                {
                    throw new ApplicationException("AccountId shouldnot be zero");//raises Application Exception
                }
            }
            get
            {
                return _accountId;
            }
        }

    }
}
