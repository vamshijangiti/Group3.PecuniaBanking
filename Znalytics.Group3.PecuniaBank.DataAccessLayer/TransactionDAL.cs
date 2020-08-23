
//CREATED BY VAMSHI JANGITI -- DATA ACCESS LAYER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    public interface ITransactionDAL
    {
        void AddTransaction(Transaction t);
        void AddTransactionDate(Transaction d);

        
        
        List<Transaction> GetTransactions(long AccountNumber);
    }

    /// <summary>
    /// DAL Class For WithDrawl And Debit
    /// </summary>
    public class TransactionDAL : ITransactionDAL
    {


        /// <summary>
        /// Collection for Transaction
        /// </summary>
        List<Transaction> transactions = new List<Transaction>();



        /// <summary>
        /// Adding the AccountNumber in to List
        /// </summary>
        /// <param name="t">Account Number</param>
        public void AddTransaction(Transaction t)
        {
            transactions.Add(t);
        }

        /// <summary>
        /// Adding the TransactionDate in to List
        /// </summary>
        /// <param name="d">Date</param>
        /// <returns></returns>
        public void AddTransactionDate(Transaction d)
        {
            transactions.Add(d);

        }


        public string GetTransactionDate(string Date)
        {
            return Date;
        }




        public List<Transaction> GetTransactions(long AccountNumber)
        {
            return transactions.FindAll(temp => temp.AccountNumber == AccountNumber);

        }


    }
}
