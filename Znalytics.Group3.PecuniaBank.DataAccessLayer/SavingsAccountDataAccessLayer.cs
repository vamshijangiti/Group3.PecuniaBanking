//Data AccessLayer for Accounts
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.AccountEntities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DataAccessLayer For Accounts 
    /// </summary>

    public class SavingsAccountDataAccessLayer : ISavingsAccountDataAccessLayer//interface
    {
        List<SavingsAccount> savingaccounts = new List<SavingsAccount>();//List of Accounts
        private List<SavingsAccount> _savingsAccount;

        //constructor
        public SavingsAccountDataAccessLayer() => savingaccounts = new List<SavingsAccount>()
            {
                new SavingsAccount() { AccountId=1, DateOfCreation = "24-08-2020", Balance = 100, },
                new SavingsAccount() { AccountId=2,DateOfCreation="25-08-2020",Balance=12000},
                new SavingsAccount() { AccountId=3, DateOfCreation = "26-08-2020", Balance = 1000, },
            };


        /* public void AddCurrentAccount(CurrentAccount c)
          {
              int maxAccountId = accounts.Max(temp => temp.AccountId);
              c.AccountId = maxAccountId;
              accounts.Add(c);
          }*/

        /// <summary>
        /// Add savings Account into the list
        /// </summary>
        /// <param name="savingsAccount">SavingsAccount</param>
        public void AddSavingsAccount(SavingsAccount savingsAccount)
        {
            int maxAccountId = savingsAccount.Max(temp => temp.AccountId);
            savingsAccount.AccountId = maxAccountId;
            savingaccounts.Add(savingsAccount);

        }
        /// <summary>
        /// Add DateOfCreation of Account
        /// </summary>
        /// <param name="d">DateOfCreation</param>
        public void AddDateOfCreation(SavingsAccount d)
        {
            savingaccounts.Add(d);

        }

        public List<SavingsAccount> GetSavingsAccount(int AccountId)
        {
            return _savingsAccount;
        }

        public void DeleteSavingsAccount(SavingsAccount s,int accountId)
        {
            if (accountId!= 0)
            {
                _savingsAccount.DeleteSavingsAccount(s);
            }
        }
    }
}

    
       
   
  

    /*    Customers Collection
        
           public class AccountDataAccessLayer : IEnumerable
    {
        List<Account> _accounts;
        public AccountDataAccessLayer()
        {
            _accounts = new List<Account>()
            {
                new Account{AccountId=1,AccountNo=13579024681,Balance=1000,DateOfCreation="25-08-2020"},
            };
        }

        public IEnumerator GetEnumerator()
        {
            for (int i; i <= _accounts.Count; i++)
            {
                yield return _accounts[i];
            }
        }

        public List<Account> GetAccounts()
        {
           
        }

        public void Add(Account account)
        {
            _accounts.Add(account);
        }

        public void UpdateAccount(Account account)
        {
         
        }
    }*/
    
