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
        bool GetAccountNumber(long acc);
        void Deposit(long transactionAccno, double trascactioAmount);
        int WithDrawlAmount(long transactionAccno, double transactionAmount);
        List<Transaction> GetTransactions(long accountNumber);
        bool SavingsTransactionValidation(string tType, double tAmount);
        bool CurrentTransactionValidation(string tType, double tAmount);
        double GetAmount(long acc);

    }
}
