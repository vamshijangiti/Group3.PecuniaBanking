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
        List<SavingsAccount> savingAccounts = new List<SavingsAccount>();//List of Accounts
     

        //constructor
        public SavingsAccountDataAccessLayer() => savingAccounts = new List<SavingsAccount>()
            {
                new SavingsAccount() { AccountId=1, DateOfCreation = "24-08-2020", Balance = 100, },
                new SavingsAccount() { AccountId=2,DateOfCreation="25-08-2020",Balance=12000},
                new SavingsAccount() { AccountId=3, DateOfCreation = "26-08-2020", Balance = 1000, },
            };

        /// <summary>
        /// Add savings Account into the list
        /// </summary>
        /// <param name="savingsAccount">SavingsAccount</param>
        public void AddSavingsAccount(SavingsAccount savingsAccount)
        {
            if (savingAccounts.Count == 0)
            {
                savingsAccount.AccountId = 0;
            }
            else
            {
                savingsAccount.AccountId = savingAccounts.Max(temp => temp.AccountId);
            }
            savingAccounts.Add(savingsAccount);

        }

        public void DeleteSavingsAccount(SavingsAccount savingsAccount)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add DateOfCreation of Account
        /// </summary>
        /// <param name="d">DateOfCreation</param>
        public void AddDateOfCreation(SavingsAccount d)
        {
            savingAccounts.Add(d);

        }

        public List<SavingsAccount> GetSavingsAccount(int AccountId)
        {
            return savingAccounts;
        }

        public void DeleteSavingsAccount(SavingsAccount s,int accountId)
        {
            if (accountId!= 0)
            {
             savingAccounts.Remove(s);
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
    
