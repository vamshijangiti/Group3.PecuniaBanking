using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{

    public class Account
    {
        public long accId;
    }

    public class CurrentAccountDataAccessLayer : Account, ICurrentAccountDataAccessLayer
    {

       
        List<CurrentAccount> currentAccount = new List<CurrentAccount>();
        public List<CurrentAccount> currentAccounts;

        

        //constructor
        public CurrentAccountDataAccessLayer() => currentAccount = new List<CurrentAccount>()
            {
                new CurrentAccount() {base.accId=1, DateOfCreation = "24-08-2020", Balance = 100 },
                new CurrentAccount() { accId=2,DateOfCreation="25-08-2020",Balance=12000},
                new CurrentAccount() { accId=3, DateOfCreation = "26-08-2020", Balance = 1000 },
            };




        public void AddCurrentAccount(CurrentAccount currentAccount)
        {
            int maxAccountId = currentAccount.Max(temp => temp.AccountId);
            currentAccount.accId = maxAccountId;
            currentAccount.AddCurrentAccount(currentAccount);
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
}

 
