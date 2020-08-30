
//CREATED BY VAMSHI JANGITI -- DATA ACCESS LAYER


using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;
using Newtonsoft.Json;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
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

    /// <summary>
    /// DAL Class For WithDrawl And Deposit
    /// </summary>
    public class TransactionDAL : ITransactionDAL
    {

        static List<Transaction> transactionList = new List<Transaction>();//list For Transaction Entity


        /// <summary>
        /// Adding the object in to List
        /// </summary>
        /// <param name="t">object</param>
        public void AddTransaction(Transaction t)
        {
            int max = 0;
            foreach (var item in transactionList)
            {
                if (item.TransactionID > max)
                {
                    max = item.TransactionID;
                }
            }
            t.TransactionID = ++max;
            transactionList.Add(t);

        }



        /// <summary>
        /// Checking the Account Number and Updating the amount
        /// </summary>
        /// <param name="taccno">Account Number</param>
        /// <param name="amount">entered amount</param>
        /// <param name="dALs">list From the Accounts </param>
        public void DepositAmount(long taccno, double amount, List<AccountDAL> dALs)
        {
            AccountDAL result = dALs.Find(temp => temp.accno == taccno);
            if (result == null)
            {

            }
            else
            {
                result.balance += amount;

            }

        }


        /// <summary>
        /// Checking the Account Number and Updating the amount
        /// </summary>
        /// <param name="accNO">Account Number</param>
        /// <param name="amount">Entered Amount</param>
        public int WithDrawlAmount(long accNO, double amount, List<AccountDAL> dALs)
        {

            AccountDAL result = dALs.Find(temp => temp.accno == accNO);
            if (result == null)
            {
                return 3;
            }
            else
            {
                if (result.balance < amount)
                    return 2;
                else
                {
                    result.balance -= amount;
                    return 1;
                }
            }
        }


        /// <summary>
        /// Returning Transactions List-- By checking the AccountNumber
        /// </summary>
        /// <param name="Accoun">Account Nummber</param>
        /// <returns>The List Of Transactions</returns>
        public List<Transaction> GetTransactionList(long Accoun)
        {

            List<Transaction> list1 = transactionList.FindAll(temp => temp.AccountNumber == Accoun);
            return list1;

        }



        /// <summary>
        /// Checks the type of Account-Savings/Current
        /// </summary>
        /// <param name="tType">Transaction Type</param>
        /// <param name="accoun">Account Number</param>
        /// <param name="dALs">List </param>
        /// <returns></returns>
        public bool TypeChecking(string tType, long accoun, List<AccountDAL> dALs)
        {
            AccountDAL result = dALs.Find(temp => temp.accno == accoun);
            if (result.TransactionType.Equals(tType))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Getting the Available balance from the Accounts
        /// </summary>
        /// <param name="accoun">Represents The Account Number</param>
        /// <param name="dALs">List from the Accounts</param>
        /// <returns></returns>
        public double GetAvailableBalance(long accoun, List<AccountDAL> dALs)
        {
            AccountDAL result = dALs.SingleOrDefault(temp => temp.accno == accoun);//used to returns the Single element
            return result.balance;
        }


        /// <summary>
        /// Getting the Account Number from the Accounts
        /// </summary>
        /// <param name="Accoun">Represents the Account Number</param>
        /// <param name="dALs">List from the Accounts</param>
        /// <returns></returns>
        public bool GetAccountNumber(long account, List<AccountDAL> dALs)
        {
            AccountDAL result = dALs.SingleOrDefault(temp => temp.accno == account); //SingleOrDefault is used to returns the single element
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;

            }
        }




        string s = JsonConvert.SerializeObject(transactionList);



    }
}
