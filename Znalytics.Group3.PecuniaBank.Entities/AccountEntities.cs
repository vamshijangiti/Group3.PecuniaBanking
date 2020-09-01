//Entities Layer created by sriram 
using System;

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
        long AccountNumber
        {
            set; get;
        }
        string DateOfCreation
        {
            set; get;
        }
        double Balance
        {
            set; get;
        }
    }
    public class SavingsAccount : IAccount
    {
        //private Fields

        /// <summary>
        /// <param name=AccountNo></param>
        /// <param name=dateOfCreation>Date of creation</param>
        /// <param name=balance>balance</param>
        /// </summary>
        private long _accountNumber;
        private string _dateOfCreation;
        private double _balance;


        public long AccountNumber
        {
            set
            {
                try
                {
                    if (value != 0)
                    {
                        _accountNumber = value;//after validation accountid is assigned to value
                    }

                }
                catch (Exception e)
                {
                    throw new AccountException("account id should not be zero or null ", e);//raises exception if accountid is nill or zero

                }

            }
            get
            {
                return _accountNumber;//returns AccountId
            }
        }



        public string DateOfCreation
        {
            set
            {
                if (value != null)
                {
                    _dateOfCreation = value;//after validation dateofcreation should be in dd:mm:yy format
                }
            }
            get
            {
                return _dateOfCreation;//dateofcreation 
            }
        }

        public double Balance
        {
            set
            {
               
                if (value !=0)//balance shouldnot be equal to zero
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
        ///<param name="AccountNumber">CrrentAccountId</param>
        ///<param name="balance">Balance</param>
        ///<param name="dateOfCreation">Date of creation</param>
        ///</summary>

        private long _accountNumber;
        private double _balance;
        private DateTime _dateOfCreation;


        public long AccountNumber
        {
            set
            {
                if (value != 0)
                {

                    _accountNumber = value;
                }

                else
                {
                    throw new AccountException("AccountId shouldnot be zero");//raises Application Exception
                }
            }
            get
            {
                return _accountNumber;
            }
        }
        public DateTime DateOfCreation
        {
            set
            {
                if (value != null)//date of creation should be in dd-mm-yyy format
                {

                    _dateOfCreation = value;
                }
            }
            get
            {
                return _dateOfCreation;//returns dateOfCreation
            }
        }
        public double Balance
        {
            set
            {
                if (value >= 500)
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