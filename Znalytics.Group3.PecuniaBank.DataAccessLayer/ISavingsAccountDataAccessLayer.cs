using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    public interface ISavingsAccountDataAccessLayer
    {
        void AddSavingsAccount(SavingsAccount savingsAccount);
        void AddDateOfCreation(SavingsAccount d);
        void DeleteSavingsAccount(SavingsAccount savingsAccount,int accountId);
        List<SavingsAccount> GetSavingsAccount(int AccountId);
   
    }
}
