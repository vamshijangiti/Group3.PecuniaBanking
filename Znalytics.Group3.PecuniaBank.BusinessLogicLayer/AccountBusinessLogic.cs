// BusinessLogicLayer created by sriram
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;
using static Znalytics.Group3.PecuniaBank.Entities.SavingsAccount;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{/// <summary>
/// BusinessLogicLayer for Accounts
/// </summary>
    public interface IAccountBusinessLogic
    {
        //methods
        void AddSavingsAccount(SavingsAccount a);
        void AddCurrentAccount(CurrentAccount account);
        void GenerateAccountId(int id);
        void DeleteSavingsAccount(SavingsAccount account);
       
    }
}

public class CurrentAccount
{
    public int AccountId { get; set; }
}
public class AccountBusinessLogic : IAccountBusinessLogic
    {
        AccountDataAccessLayer _accountDataAccessLayer;
     
    
        public AccountBusinessLogic()
        {
            _accountDataAccessLayer = new AccountDataAccessLayer();
        }

        public void AddSavingsAccount(SavingsAccount a)
        {

            if (a.AccountId != 0)
                {
            _accountDataAccessLayer.AddSavingsAccount(a);
                }
                else
                {
            throw new ApplicationException("account no should not be null");//Exception raised if accountid is zero
                }
            }
            
        public void AddCurrentAccount(CurrentAccount account)
        {
            if (account.AccountId!=0)
            {
            _accountDataAccessLayer.AddCurrentAccount(account);
            }
            else
            {
                throw new ApplicationException("account should not be null");
            }
        }
        /// <summary>
        /// Adding Accounts
        /// </summary>
        /// <param name="account">Add Account</param>
    
        //GetAccounts
        public List<Account> GetAccounts()
        {
            return _accountDataAccessLayer.GetAccounts();
        }
            /// <summary>
            /// Update Accounts
            /// </summary>
            /// <param name="account">update</param>
            public void DeleteCurrentAccount(CurrentAccount account)
        {
            if (account.AccountId==null)
            {
                _accountDataAccessLayer.DeleteCurrentAccount(account);
            }
        }
    public void DeleteSavingsAccount(SavingsAccount account)
    {
        if (account.AccountId == null)
        {
            _accountDataAccessLayer.DeleteAccount(account);
        }
    }

    public void GenerateAccountId(int id)
    {
     
    }
}

  