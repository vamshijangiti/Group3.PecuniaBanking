using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    public interface IAccountDataAccessLayer
    {
        void AddSavingsAccount(SavingsAccount savingAccount);
        void AddCurrentAccount(CurrentAccount currentAccount);
        void AddDateOfCreation(SavingsAccount d);
        List<SavingsAccount> GetAccounts(long AccountNo);
   
    }
}
