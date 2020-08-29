
//VAMSHI JANGITI BUSINESS LOGIC LAYER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{

    /// <summary>
    /// Interface For BLL
    /// </summary>
    public interface ITransactionBLL
    {
        bool ValidateAccountNumber(long accNumber);
        bool ValidateWithDrawl(double d1);
        bool ValidateEnteredAmount(double d2);
        void AddTranscation(Transaction t1);
        long GetAccountNumber();
    }


    /// <summary>
    /// Business Logic Layer For WithDrawl And Debit
    /// </summary>
    public class TransactionBusinessLogic : ITransactionBLL
    {
        //creating 
        ITransactionDAL transactionDAL = new TransactionDAL();
        Transaction transaction = new Transaction();
        AccountDAL accountDALs = new AccountDetailDAL();


        /// <summary>
        /// Validation Of AccountNumber-Account Number Of Customer should Be Less than 10
        /// </summary>
        /// <param name="_accNumber">Account Number</param>
        /// <returns></returns>
        public bool ValidateAccountNumber(long accNumber)
        {
            //if (_name.Length > 10)
            string l = accNumber + "";
            if (l.Length == 3||!string.IsNullOrEmpty(l))
            {

                // transactionDAL.GetTransactions(accNumber);
                return true;
            }
            else
            {
                //throw new Exception(" \nplease check Account number \n");
                return false;
            }
        }



        /// <summary>
        /// Validation For Withdrawl - minimum balance is 5000
        /// </summary>
        /// <param name="d1">Entered Balance</param>
        /// <returns></returns>
        public bool ValidateWithDrawl(double d1)
        {
            if (accountDALs.balance - d1 >= 5000)
            {
                return true;
            }
            else
            {
                //Minimum Balance is 5000
                //throw new Exception("\n Minimum Balance is 5000 ");
                return false;
            }
        }


        /// <summary>
        /// Validation For Deposit - entered amount should be greater than 500
        /// </summary>
        /// <param name="d2">Deposit Amount </param>
        /// <returns></returns>
        public bool ValidateEnteredAmount(double d2)
        {

            if (d2 >= 500)
            {
                return true;
            }
            else
            {
                //The Deposit Should be More Than 500 rs
                return false;
            }
        }



        /// <summary>
        ///passing the object to the DAL
        /// </summary>
        /// <param name="t1">object</param>
        public void AddTranscation(Transaction t1)
        {
            transactionDAL.AddTransaction(t1);

        }



        /// <summary>
        /// Getting the Account Number From DAL
        /// </summary>
        /// <returns>AccountNumber</returns>
        public long GetAccountNumber()
        {
            return transactionDAL.GetAccountNumber();
        }



        /// <summary>
        /// Adding the Deposited Amount
        /// </summary>
        /// <param name="transactionAccno">Account NUmber</param>
        /// <param name="trascactioAmount">Amount</param>
        public void Deposit(long transactionAccno, double trascactioAmount)
        {
            transactionDAL.DepositAmount(transactionAccno, trascactioAmount);
        }



        /// <summary>
        /// Adding the WithDrawl Amount
        /// </summary>
        /// <param name="t2">Transaction Object</param>
        public void WithDrawlAmount(long transactionAccno, double transactionAmount)
        {
            transactionDAL.WithDrawlAmount(transactionAccno, transactionAmount);
        }




        /// <summary>
        /// List For Getting the Transaction details by AccountNumber from Other's Class
        /// </summary>
        /// <param name="AccountNumber">Account Number</param>
        /// <returns></returns>
        public List<Transaction> GetTransactions(long accountNumber)
        {

            List<Transaction> tx = null;
            if (ValidateAccountNumber(accountNumber))
            {
                tx = transactionDAL.GetTransactionList(accountNumber);
            }
            return tx;
        }

        /// <summary>
        /// Getting the Ammount
        /// </summary>
        /// <param name="acc">Account Number</param>
        /// <returns></returns>
        public double GetAmount(long acc)
        {
            return transactionDAL.GetAvailableBalance(acc);
        }
    }
}


