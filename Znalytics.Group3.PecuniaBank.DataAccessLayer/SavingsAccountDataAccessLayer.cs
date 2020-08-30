//Data AccessLayer for Accounts
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.HousingLoanEntities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DataAccessLayer For Accounts 
    /// </summary>


    public class SavingsAccountDataAccessLayer : ISavingsAccountDataAccessLayer//interface
    {
        List<SavingsAccount> savingaccounts = new List<SavingsAccount>();//List of Accounts
        private List<SavingsAccount> savingsAccount;

        //constructor
        public SavingsAccountDataAccessLayer() => savingaccounts = new List<SavingsAccount>()
            {
                new SavingsAccount() { AccountId=1, DateOfCreation = "24-08-2020", Balance = 100, BranchName = "pecunia" },
                new SavingsAccount() { AccountId=2,DateOfCreation="25-08-2020",Balance=12000,BranchName="pecunia"},
                new SavingsAccount() { AccountId=3, DateOfCreation = "26-08-2020", Balance = 1000, BranchName = "pecunia" },
            };


        /*  public void AddCurrentAccount(CurrentAccount c)
          {
              int maxAccountId = accounts.Max(temp => temp.AccountId);
              c.AccountId = maxAccountId;
              accounts.Add(c);
          }*/

        /// <summary>
        /// Add Account into the list
        /// </summary>
        /// <param name="n">Account</param>
        public void AddSavingsAccount(SavingsAccount savingsAccount)
        {
           /* int maxAccountId = savingsAccount.Max(temp => temp.AccountId);*/
            /*savingsAccount.AccountId = maxAccountId;*/
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

        public List<SavingsAccount> GetSavingsAccount()
        {
            throw new NotImplementedException();
        }

        public List<SavingsAccount> GetSavingsAccount(int AccountId)
        {
            return savingsAccount;
        }

        public void DeleteSavingsAccount(SavingsAccount savingsAccount,int accountId)
        {
            if (accountId!= 0)
            {
               /* savingsAccount.DeleteSavingsAccount(savingsAccount);*/
            }
        }

        public void DeleteAccount(SavingsAccount savingsaccount)
        {
            throw new NotImplementedException();
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
    
