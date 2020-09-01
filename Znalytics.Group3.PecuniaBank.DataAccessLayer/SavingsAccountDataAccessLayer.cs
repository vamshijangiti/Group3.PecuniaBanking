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
                new SavingsAccount() { AccountNumber=101, DateOfCreation = "24-08-2020", Balance = 1000, },
                new SavingsAccount() { AccountNumber=102,DateOfCreation="25-08-2020",Balance=12000},
                new SavingsAccount() { AccountNumber=103, DateOfCreation = "26-08-2020", Balance = 1000, },
            };

        /// <summary>
        /// Add savings Account into the list
        /// </summary>
        /// <param name="savingsAccount">SavingsAccount</param>
        public void AddSavingsAccount(SavingsAccount savingsAccount)
        {
            if (savingAccounts.Count == 0)
            {
                savingsAccount.AccountNumber = 0;
            }
            else
            {
                savingsAccount.AccountNumber = savingAccounts.Max(temp => temp.AccountNumber);
            }
            savingAccounts.Add(savingsAccount);

        }
        //Convert data into Json
        public static void SaveIntoFile(int SavingsAccount)
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

        public SavingsAccount GetSavingsAccount(long accountNumber)
        {
            return savingAccounts.Find(temp => temp.AccountNumber == accountNumber);
            //return savingAccounts;
        }

        public void DeleteSavingsAccount(SavingsAccount s, long _accountNumber)
        {
            if (_accountNumber != 0)
            {
                savingAccounts.Remove(s);
            }
        }
    }
}
  
