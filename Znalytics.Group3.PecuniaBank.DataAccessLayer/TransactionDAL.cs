
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

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// Interface For the DAL
    /// </summary>
    public interface ITransactionDAL
    {
        void AddTransaction(Transaction t);
        void DepositAmount(long accNO, double amount);
        List<Transaction> GetTransactionList(long AccountNumber);
        void WithDrawlAmount(long accNO, double amount);
        long GetAccountNumber();
        double GetAvailableBalance(long Accoun);
    }

    /// <summary>
    /// DAL Class For WithDrawl And Debit
    /// </summary>
    public class TransactionDAL : ITransactionDAL
    {

        //Creating the Objects
        List<Transaction> transactionList = new List<Transaction>();
        AccountDetailDAL accountDALs = new AccountDetailDAL();
        List<AccountDAL> dALs = AccountDetailDAL.Getaccounts();



        /// <summary>
        /// Adding the object in to List
        /// </summary>
        /// <param name="t">object</param>
        public void AddTransaction(Transaction t)
        {
            transactionList.Add(t);

        }


        /// <summary>
        /// Getting the Account Number from Other's Class
        /// </summary>
        /// <returns>Account Number</returns>
        public long GetAccountNumber()
        {
            return accountDALs.GetAccountNumber;
        }



        /// <summary>
        /// Checking the Account Number and Updating the amount
        /// </summary>
        /// <param name="taccno">Account Number</param>
        /// <param name="amount">entered amount</param>
        public void DepositAmount(long taccno, double amount)
        {
            //Using Find Method --the Account Number checks the 
            AccountDAL result = dALs.Find(temp => temp.accno == taccno);

            if (result == null)
            {
                throw new Exception("Account Number Doesn't Exists");
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
        public void WithDrawlAmount(long accNO, double amount)
        {
            //using Find Method the WithDrawling amount is done
            AccountDAL result = dALs.Find(temp => temp.accno == accNO);

            if (result == null)
            {
                throw new Exception("\nThe Account Number Doesn't Exists \n");
            }
            else
            {
                result.balance -= amount;

            }

        }


        /// <summary>
        /// Returning Transactions List-- By checking the AccountNumber
        /// </summary>
        /// <param name="Accoun">Account Number</param>
        /// <returns></returns>
        public List<Transaction> GetTransactionList(long Accoun)
        {

            List<Transaction> list1 = transactionList.FindAll(temp => temp.AccountNumber == Accoun);
            foreach (var item in list1)
            {
                Console.WriteLine(item.AccountNumber + " " + item.TransactionAmount);
            }
            return list1;

        }

        /// <summary>
        /// Get Method For getting the Balance
        /// </summary>
        /// <param name="Accoun">AccountNUmber</param>
        /// <returns></returns>
        public double GetAvailableBalance(long Accoun)
        {
            //returns the Balance
            return accountDALs.GetAmount;
            
        }
    }
}
