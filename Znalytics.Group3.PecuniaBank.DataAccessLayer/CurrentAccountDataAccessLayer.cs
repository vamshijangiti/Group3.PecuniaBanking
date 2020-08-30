using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    public class CurrentAccountDataAccessLayer
    {
        /* public class CurrentAccountDataAccessLayer : ICurrentAccountDataAccessLayer//interface
         {
             List<CurrentAccount> currentAccount = new List<CurrentAccount>();//List of Accounts
             private List<CurrentAccount> savingsAccount;

             //constructor
             public CurrentAccountDataAccessLayer() => currentAccount = new List<CurrentAccount>()
             {
                 new CurrentAccount() { AccountId=1, DateOfCreation = "24-08-2020", Balance = 100, BranchName = "pecunia" },
                 new CurrentAccount() { AccountId=2,DateOfCreation="25-08-2020",Balance=12000,BranchName="pecunia"},
                 new CurrentAccount() { AccountId=3, DateOfCreation = "26-08-2020", Balance = 1000, BranchName = "pecunia" },
             };




             public void AddCurrentAccount(CurrentAccount currentAccount)
             {
                 int maxAccountId = currentAccount.Max(temp => temp.AccountId);
                 currentAccount.AccountId = maxAccountId;
                 currentAccount.Add(currentAccount);
             }

             public void AddDateOfCreation(CurrentAccount d)
             {
                 throw new NotImplementedException();
             }
             public void DeleteCurrentAccount(CurrentAccount currentAccount, int accountId)
             {
                 throw new NotImplementedException();
             }

             List<CurrentAccount> ICurrentAccountDataAccessLayer.GetCurrentAccount(int AccountId)
             {
                 throw new NotImplementedException();
             }
         }
     }
 }*/
    }

 
