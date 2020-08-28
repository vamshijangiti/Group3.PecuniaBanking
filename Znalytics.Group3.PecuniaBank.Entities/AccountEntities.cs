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
     
        private int  _accountId;
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

        public Account Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
  
} 