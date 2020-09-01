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
    /// </summary
    ///<summary>
    ///interface named as IAccount
    ///</summary>
    interface IAccount   //Interface is a pure Abstract class which acts as a contract between two developers
                            //i.e; here IAccount means SavingsAccount and CurrentAccount
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
        /// <param name=balance>balance</param>
        /// </summary>
        private int _accountId;
        private string _dateOfCreation;
        private long _balance;


        public int AccountId
        {
            set
            {
                try
                {
                    if (_accountId != 0)
                    {
                        _accountId = value;//after validation accountid is assigned to value
                    }

                }
                catch (Exception e)
                {
                    throw new AccountException("account id should not be zero or null ", e);//raises exception if accountid is nill or zero
                }

            }
            get
            {
                return _accountId;//returns AccountId
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
                if (_balance >= 500)//balance shouldnot be equal to zero
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
    }




    public class CurrentAccount //: IAccount
    {
        ///<summary>
        ///<param name="AccountId">CrrentAccountId</param>
        ///<param name="balance">Balance</param>
        ///<param name="dateOfCreation">Date of creation</param>
        ///</summary>
        
        private int _accountId;
        private long _balance;
        private DateTime _dateOfCreation;


        public int AccountId
        {
            set
            {
                if (_accountId != 0)
                {

                    _accountId = value;
                }

                else
                {
                    throw new AccountException("AccountId shouldnot be zero");//raises Application Exception
                }
            }
            get
            {
                return _accountId;
            }
        }
        public DateTime DateOfCreation
        {
            set
            {
                if (_dateOfCreation!=null)//date of creation should be in dd-mm-yyy format
                {

                    _dateOfCreation =value;
                }
            }
            get
            {
                return _dateOfCreation;//returns dateOfCreation
            }
        }
        public long Balance
        {
            set
            {
                if (_balance>=500)
                {
                    _balance = value;
                }
                else
                {
                    throw new AccountException("balance should be greater than 500");//raises Exception if balance lessthan 500
                }
            }
            get
            {
                return _balance;// returns Balance
            }
        }
    }

}