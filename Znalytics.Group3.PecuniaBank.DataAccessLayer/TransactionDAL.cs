﻿
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
        void Deposit(Transaction t1);
        void WithDrawl(Transaction t2);
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
        /// Deposit Method
        /// </summary>
        /// <param name="t1">Object for Transaction</param>
        public void Deposit(Transaction t1)
        {
            Transaction t = transactions.Find(n => n.AccountNumber == t1.AccountNumber);
            {
                t.TransactionAmount = t1.TransactionAmount;
                // return t1.TransactionAmount;
            }

        }


        public void WithDrawl(Transaction t2)
        {
            Transaction t3 = transactions.Find(n => n.AccountNumber == t2.AccountNumber);
            {
                t3.TransactionAmount = t2.TransactionAmount;
            }
        }
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

        /// <summary>
        /// Represents the Date 
        /// </summary>
        /// <param name="Date"></param>
        /// <returns></returns>
        public string GetTransactionDate(string Date)
        {
            return Date;
        }



        /// <summary>
        /// Finding the Account Number
        /// </summary>
        /// <param name="AccountNumber"></param>
        /// <returns></returns>
        public List<Transaction> GetTransactions(long AccountNumber)
        {
            return transactions.FindAll(temp => temp.AccountNumber == AccountNumber);

        }


    }
}
