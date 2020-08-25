//Data AccessLayer for Accounts
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;
namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DataAccessLayer For Accounts 
    /// </summary>
    public interface IAccountDataAccessLayer
    {
        void AddAccount(Account n);
        void AddDateOfCreation(Account d);
        List<Account> GetAccounts(long AccountNo);
        void UpdateAccount(Account accounts);

    }
    public class AccountDataAccessLayer : IAccountDataAccessLayer//interface
    {
        List<Account> accounts = new List<Account>();//List of Accounts
      
        //constructor
        public AccountDataAccessLayer()
        {
            accounts = new List<Account>()
            {
                new Account() { AccountNo=6200-2340-641, DateOfCreation = "24-08-2020", Balance = 100, BranchName = "pecunia" },
                new Account() { AccountNo=6200-2210-243,DateOfCreation="25-08-2020",Balance=12000,BranchName="pecunia"},
                new Account() { AccountNo= 6200-2100-321, DateOfCreation = "26-08-2020", Balance = 1000, BranchName = "pecunia" },
            };
        }

        public List<Account> GetAccounts()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add Account into the list
        /// </summary>
        /// <param name="n">Account</param>
        public void AddAccount(Account n)
        {
            accounts.Add(n);
            accounts.Add(n);
            accounts.Add(n);
        }
        /// <summary>
        /// Add DateOfCreation of Account
        /// </summary>
        /// <param name="d">DateOfCreation</param>
        public void AddDateOfCreation(Account d)
        {
            accounts.Add(d);
            accounts.Add(d);
            accounts.Add(d);
        }
        /// <summary>
        /// retrieve accounts
        /// </summary>
        /// <param name="AccountNo">GetAccounts</param>
        /// <returns></returns>
        public List<Account> GetAccounts(long AccountNo)
        {
            return accounts;
        }
        /// <summary>
        /// Update Accounts 
        /// </summary>
        /// <param name="accounts">Update</param>
        public void UpdateAccount(Account accounts)
        {
            Account acc = accounts.Find(temp => temp.AccountNo == accounts.AccountNo);
            if(acc!=null){
                acc.AccountNo = accounts.AccountNo;
            }
        }
    }
  
}

    /*    Customers Collection
     *    
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
    
