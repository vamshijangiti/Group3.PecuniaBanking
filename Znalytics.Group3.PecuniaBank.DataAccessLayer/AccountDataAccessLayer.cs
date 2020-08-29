//Data AccessLayer for Accounts
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;
using static Znalytics.Group3.PecuniaBank.Entities.SavingsAccount;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DataAccessLayer For Accounts 
    /// </summary>
    public interface IAccountDataAccessLayer// interface 
    {
        void AddSavingsAccount(SavingsAccount s);
        void AddCurrentAccount(CurrentAccount c);
        void AddDateOfCreation(SavingsAccount d);
        List<SavingsAccount> GetSavingAccounts(int accountId);
     
        
    }

    public class CurrentAccount
    {
    }



    public class SavingsAccountDataAccessLayer : IAccountDataAccessLayer//interface
    {
        List<SavingsAccount> accounts = new List<SavingsAccount>();//List of Accounts

        //constructor
        public SavingsAccountDataAccessLayer() => accounts = new List<SavingsAccount>()
            {
                new SavingsAccount() { AccountId=1, DateOfCreation = "24-08-2020", Balance = 100, BranchName = "pecunia" },
                new SavingsAccount() { AccountId=2,DateOfCreation="25-08-2020",Balance=12000,BranchName="pecunia"},
                new SavingsAccount() { AccountId=3, DateOfCreation = "26-08-2020", Balance = 1000, BranchName = "pecunia" },
            };


        public void AddCurrentAccount(CurrentAccount c)
        {
            int maxAccountId = accounts.Max(temp => temp.AccountId);
            c.AccountId = maxAccountId;
            accounts.Add(c);
        }

        /// <summary>
        /// Add Account into the list
        /// </summary>
        /// <param name="n">Account</param>
        public void AddSavingsAccount(SavingsAccount savingAccount)
        {
            accounts.Add(savingAccount);

        }

        public List<SavingsAccount> GetSavingAccounts()
        {
            throw new ApplicationException();
        }

        /// <summary>
        /// Add DateOfCreation of Account
        /// </summary>
        /// <param name="d">DateOfCreation</param>
        public void AddDateOfCreation(SavingsAccount d)
        {
            accounts.Add(d);

        }

        public void DeleteSavingsAccount(SavingsAccount account)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// retrieve accounts
        /// </summary>
        /// <param name="AccountNo">GetAccounts</param>
        /// <returns></returns>
        public List<SavingsAccount> GetSavingAccounts(long AccountNo)
        {
            return accounts;
        }
        /// <summary>
        /// Update Accounts 
        /// </summary>
        /// <param name="accounts">Update</param>
        public void CurrentAccount(CurrentAccount accounts)
        {
            CurrentAccount acc = accounts.Find(temp =>
            {
                return temp.AccountId == accounts.AccountId;
            });


            if (acc != null)
            {
                acc.AccountId = accounts.AccountId;
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
    
