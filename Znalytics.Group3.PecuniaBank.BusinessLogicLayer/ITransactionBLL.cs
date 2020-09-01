using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    /// <summary>
    /// Interface For BLL
    /// </summary>
    public interface ITransactionBLL
    {
        void AddTranscation(Transaction t1);
        int ValidateAccountNumber(string accNumber);
        bool ValidateEnteredAmount(double d2);
        void DepositAmount(Transaction t);
        int WithDrawlAmount(Transaction t);
        bool CheckAccountNumber(long accountNumber);
        List<Transaction> GetTransactions(long accountNumber);
 

    }
}
