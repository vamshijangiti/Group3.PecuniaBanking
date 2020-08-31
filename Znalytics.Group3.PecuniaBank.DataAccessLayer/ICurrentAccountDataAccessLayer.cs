using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using static Znalytics.Group3.PecuniaBank.AccountEntities.SavingsAccount;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    interface  ICurrentAccountDataAccessLayer
    {
        void AddCurrentAccount(CurrentAccount currentAccount);
        void DeleteCurrentAccount(CurrentAccount currentAccount, int accountId);
        List<CurrentAccount> GetCurrentAccounts();
    }
}
