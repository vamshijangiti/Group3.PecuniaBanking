//Entities Layer created by sriram 
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Znalytics.Group3.PecuniaBank.AccountEntities
{
    /// <summary>
    /// Entity Layer for BankLayer
    /// </summary>
    interface IAccount
    {
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
        /// <param name=dateOfCreation</param>
        /// <param name=Balance></param>
        /// </summary>
        private int _accountId;
        private string _dateOfCreation;
        private string _branchName;
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
        public string BranchName
        {
            set
            {
                if (_branchName.Length <= 30)
                {
                    _branchName = value;//branchname should contain lessthan 30 characters and then assigns to value
                }
            }
            get
            {
                return _branchName;
            }
        }
        public long Balance
        {
            set
            {
                if (_balance != 0)//balance shouldnot be equal to zero
                {
                    _balance = value;//balance 
                }
                else
                {
                    throw new AccountException("your balance should be not be equal to zero");
                }
            }
            get
            {
                return _balance;//returns balance
            }
        }



        /*  public class CurrentAccount : IAccount
          {
              public int AccountId;
              public string DateOfCreation;
              public int Balance;
              private int _accId;
              private long _balance;
              private string _dateOfCreation;

              public CurrentAccount()
              {
              }

              public CurrentAccount(int accId, long balance, string dateOfCreation)
              {
                  _accId = accId;
                  _balance = balance;
                  _dateOfCreation = dateOfCreation;
              }
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
                      throw new ApplicationException("AccountId shouldnot be null");
                  }
              }
              get
              {
                  return _accountId;
              }
          }



          }*/



        /* void AccountId(int accountId)
          {
              throw new NotImplementedException();
          }*/
    }
}
  

