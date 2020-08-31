using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// 
    /// </summary>
    public class CurrentAccountDataAccessLayer : ICurrentAccountDataAccessLayer//interface
    {

        List<CurrentAccount> currentAccounts = new List<CurrentAccount>();

        //constructor
        public CurrentAccountDataAccessLayer() => currentAccounts = new List<CurrentAccount>()
             {
                 new CurrentAccount() { AccountId =1, DateOfCreation = Convert.ToDateTime("24-08-2020"), Balance = 100 },
                 new CurrentAccount() { AccountId=2, DateOfCreation = Convert.ToDateTime("25-08-2020"), Balance =12000},
                 new CurrentAccount() { AccountId=3, DateOfCreation = Convert.ToDateTime("26-08-2020"), Balance = 1000 },
             };




        public void AddCurrentAccount(CurrentAccount currentAccount)
        {
            if (currentAccounts.Count == 0)
            {
                currentAccount.AccountId = 0;
            }
            else
            {
                currentAccount.AccountId = currentAccounts.Max(temp => temp.AccountId);
            }
            currentAccounts.Add(currentAccount);
        }

        public void DeleteCurrentAccount(CurrentAccount currentAccount, int accountId)
        {
            throw new NotImplementedException();
        }

        /*  List<CurrentAccount> ICurrentAccountDataAccessLayer.GetCurrentAccount(int AccountId)
          {
              throw new NotImplementedException();
          }
      }*/
    }
}


