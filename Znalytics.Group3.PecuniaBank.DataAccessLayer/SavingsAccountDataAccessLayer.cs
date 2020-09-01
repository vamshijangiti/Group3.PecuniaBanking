//Data AccessLayer for Accounts
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using System.IO;

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
                new SavingsAccount() { AccountNo=1, DateOfCreation = "24-08-2020", Balance = 100, },
                new SavingsAccount() { AccountNo=2,DateOfCreation="25-08-2020",Balance=12000},
                new SavingsAccount() { AccountNo=3, DateOfCreation = "26-08-2020", Balance = 1000, },
            };

        /// <summary>
        /// Add savings Account into the list
        /// </summary>
        /// <param name="savingsAccount">SavingsAccount</param>
        public void AddSavingsAccount(SavingsAccount savingsAccount)
        {
            if (savingAccounts.Count == 0)
            {
                savingsAccount.AccountNo = 0;
            }
            else
            {
                savingsAccount.AccountNo = savingAccounts.Max(temp => temp.AccountNo);
            }
            savingAccounts.Add(savingsAccount);

        }
        //Convert data into Json
        public static void SaveIntoFile( int SavingsAccount)
        {
            string v = JsonConvert.SerializeObject(SavingsAccount);
            string s = v;
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\source\repos\Group3.PecuniaBanking\savingsAccount.txt");
            streamWriter.Write(s);
            streamWriter.Close();
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

        public List<SavingsAccount> GetSavingsAccount(int AccountNo)
        {
            return savingAccounts;
        }

        public void DeleteSavingsAccount(SavingsAccount s,int AccountNo)
        {
            if (AccountNo!= 0)
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
    
