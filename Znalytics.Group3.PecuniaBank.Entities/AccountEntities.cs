//Entities Layer created by sriram 
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Znalytics.Group3.PecuniaBank.Entities
{
    /// <summary>
    /// Entity Layer for BankLayer
    /// </summary>


    public class Account
    {
        //private Fields
     
        private long _accountNo;
        private string _dateOfCreation;
        private string _branchName;
        private long _balance;
       
       /* public int AccountId
        {
            set
            {
                if (_accountId != 0)
                {
                    _accountId = value;//after validation accountid is assigned to value
                }
                else
                {
                    throw new Exception("account id should not be zero or null ");//raises exception if accountid is nill or zero
                }

            }
            get
            {
                return _accountId;//returns accountId
            }
        }*/
        public long AccountNo
        {
            set
            {
                if (_accountNo ==11)//accountno should be 11 digit Number
                {
                    _accountNo = value;
                }
                else
                {
                    throw new AccountException("Please enter a valid accountNo");
                }
            }
            get
            {
                return _accountNo;//readonly property
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

        public Account Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
  
} 