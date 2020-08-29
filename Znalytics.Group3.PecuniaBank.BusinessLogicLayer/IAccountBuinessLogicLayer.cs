using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    public interface  IAccountBuinessLogicLayer
    {
        void AddSavingsAccount(SavingsAccount savingsAccount);
        void AddCurrentAccount(CurrentAccount currentAccount);
        void GenerateAccountId(int id);
        void DeleteSavingsAccount(SavingsAccount savingsAccount);
        void DeleteCurrentAccount(CurrentAccount currentAccount);

    }
}
