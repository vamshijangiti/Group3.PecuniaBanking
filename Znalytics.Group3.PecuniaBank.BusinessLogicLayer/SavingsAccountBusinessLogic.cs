// BusinessLogicLayer created by sriram
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.AccountEntities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{/// <summary>
 /// BusinessLogicLayer for Accounts
 /// </summary
  

    public class SavingsAccountBusinessLogic : ISavingsAccountBusinessLogic
    {
        SavingsAccountDataAccessLayer _savingsaccountDataAccessLayer;


        public SavingsAccountBusinessLogic()
        {
            _savingsaccountDataAccessLayer = new SavingsAccountDataAccessLayer();
        }
        /// <summary>
        /// Adding savingAccount
        /// </summary>
        /// <param name="savingsAccount"></param>
        public void AddSavingsAccount(SavingsAccount savingsAccount)
        {
            try
            {
                if (savingsAccount.AccountNumber != 0)
                {
                    _savingsaccountDataAccessLayer.AddSavingsAccount(savingsAccount);
                }
            }
            catch (Exception e)
            {
                throw new AccountException("account no should not be null", e);//Exception raised if accountid is zero
            }
        }

        public void DeleteSavingsAccount(SavingsAccount savingsAccount)
        {
            _savingsaccountDataAccessLayer.DeleteSavingsAccount(savingsAccount);//deletes savingsAccount
        }
        public List<SavingsAccount> GetSavingsAccounts()
        {
            return GetSavingsAccounts();//retrieves all currentAccount 
        }
    }

    public class AccountDetailBLL : IAccountsBusinessLogic
    {
        SavingsAccount current = new SavingsAccount();
        SavingsAccountDataAccessLayer s;
        public AccountDetailBLL()
        {
            s = new SavingsAccountDataAccessLayer();
        }
        List<SavingsAccount> savings = new List<SavingsAccount>();


        //public 

        public List<AccountDetailBLL> GetAccounts()
        {
            return new List<AccountDetailBLL>() { };
        }
        public SavingsAccount GetAccountByAccountNumber(long accountNumber)
        {
            SavingsAccount ac = s.GetSavingsAccount(accountNumber);
            return ac;
        }

        public void UpdateAccount(AccountDetailBLL account)
        {

        }
    }
}

    
