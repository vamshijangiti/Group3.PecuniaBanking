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
        List<Transaction> GetTransactionList(long AccountNumber);
        void Deposit(Transaction t);
    }
}
