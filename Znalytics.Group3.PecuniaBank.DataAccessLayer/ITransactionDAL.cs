using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// Interface For Transaction DAL
    /// </summary>
    public interface ITransactionDAL
    {
        void AddTransaction(Transaction t);
        void DepositAmount(long accNO, double amount, List<AccountDAL> dALs);
        List<Transaction> GetTransactionList(long AccountNumber);
        int WithDrawlAmount(long accNO, double amount, List<AccountDAL> dALs);
        bool GetAccountNumber(long acc, List<AccountDAL> dALs);
        double GetAvailableBalance(long Accoun, List<AccountDAL> dALs);
        bool TypeChecking(string tType, long accoun, List<AccountDAL> dALs);
    }
}
