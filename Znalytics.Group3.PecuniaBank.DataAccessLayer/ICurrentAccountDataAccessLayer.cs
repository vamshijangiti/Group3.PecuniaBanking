using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Znalytics.Group3.PecuniaBank.HousingLoanEntities.SavingsAccount;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    interface  ICurrentAccountDataAccessLayer
    {
        void AddCurrentAccount(CurrentAccount currentAccount);
        void AddDateOfCreation(CurrentAccount d);
        void DeleteCurrentAccount(CurrentAccount currentAccount, int accountId);
        List<CurrentAccount> GetCurrentAccount(int AccountId);

    }

    public class CurrentAccount
    {
    }
}
