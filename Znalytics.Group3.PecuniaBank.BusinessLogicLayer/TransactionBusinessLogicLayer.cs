
//VAMSHI JANGITI BUSINESS LOGIC LAYER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer.IAccountDetails;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.Group3.PecuniaBank.Entities.TransactionException;

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


    /// <summary>
    /// Business Logic Layer For WithDrawl And Debit
    /// </summary>
    public class TransactionBusinessLogic : ApplicationException, ITransactionBLL
    {
        //creating objects for other classes
        ITransactionDAL transactionDAL = new TransactionDAL();
        Transaction transaction = new Transaction();
        static List<AccountDAL> dALs;

        /// <summary>
        /// Constructor for BLL
        /// </summary>
        public TransactionBusinessLogic()
        {
            try
            {
                if (dALs == null)
                    dALs = AccountDetailBLL.GetAccountBLLAccList();
            }
            catch (Exception e)
            {
                Console.WriteLine("The Transactions are Not Added");
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
        /// Validation Of AccountNumber-Account Number Of Customer should Be Less than 10
        /// </summary>
        /// <param name="_accNumber">Account Number</param>
        /// <returns></returns>
        public int ValidateAccountNumber(string accNumber)
        {
            // Regex regex = new Regex("[0-9]");
            if (string.IsNullOrEmpty(accNumber))
            {
                return 1;//should not be taken
            }
            else if (!Regex.IsMatch(accNumber, @"/d"))
            {

                if (accNumber.Length == 3)
                {
                    return 3;

                }
                else

                    return 2;//more than 3
            }
            else
            {
                return 4;//all includes
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
                return false;//The Deposit Should be More Than 500 rs
            }
        }


        /// <summary>
        /// Adding the Deposited Amount
        /// </summary>
        /// <param name="transactionAccno">Account NUmber</param>
        /// <param name="trascactioAmount">Amount</param>
        public void Deposit(long transactionAccno, double trascactioAmount)
        {
            transactionDAL.DepositAmount(transactionAccno, trascactioAmount, dALs);
        }



        /// <summary>
        /// Adding the WithDrawl Amount
        /// </summary>
        /// <param name="t2">Transaction Object</param>
        public int WithDrawlAmount(long transactionAccno, double transactionAmount)
        {
            return transactionDAL.WithDrawlAmount(transactionAccno, transactionAmount, dALs);
        }




        /// <summary>
        /// List For Getting the Transaction details by AccountNumber from Other's Class
        /// </summary>
        /// <param name="AccountNumber">Account Number</param>
        /// <returns></returns>
        public List<Transaction> GetTransactions(long accountNumber)
        {

            List<Transaction> tx = null;
            //   if (ValidateAccountNumber(accountNumber)==3)
            // {
            tx = transactionDAL.GetTransactionList(accountNumber);
            //}
            return tx;
        }



        /// <summary>
        /// Validation For Savings--should not Exceed more than 1 lakh
        /// </summary>
        /// <param name="tamount">Entered Amount</param>
        /// <param name=" tType">Transaction type</param>
        /// <returns>if it exceeds 1 lakh returns false else true</returns>
        public bool SavingsTransactionValidation(string tType, double tAmount)
        {
            //if both Conditions become true then the amount will be deposited
            if (tType.Equals("Savings") && tAmount <= 100000 && tAmount > 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        /// <summary>
        /// Checking the Type Of Account--Savings / Current
        /// </summary>
        /// <param name="tType">TransactionType</param>
        /// <param name="accoun">AccontNumber</param>
        /// <returns>True if Account Exists</returns>
        public bool TypeCheck(string tType, long accoun)
        {
            bool y = transactionDAL.TypeChecking(tType, accoun, dALs);
            //if both Conditions become true then the amount will be deposited
            return y;
        }




        /// <summary>
        /// Validattion Method for Current Account Transaction --- should not Exceed more than 5 lakh
        /// </summary>
        /// <param name="tType">Type Of Transaction</param>
        /// <param name="tAmount">Transaction Amount</param>
        /// <returns></returns>
        public bool CurrentTransactionValidation(string tType, double tAmount)
        {
            if (tType.Equals("Current") && tAmount <= 1000000 && tAmount > 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Getting the Amount From the Accounts class
        /// </summary>
        /// <param name="acc">Represents the Account Number</param>
        /// <returns></returns>
        public double GetAmount(long acc)
        {
            return transactionDAL.GetAvailableBalance(acc, dALs);
        }



        /// <summary>
        /// Represents the Account Number from Accounts class
        /// </summary>
        /// <param name="acc">Account Number</param>
        /// <returns></returns>
        public bool GetAccountNumber(long acc)
        {
            return transactionDAL.GetAccountNumber(acc, dALs);
        }




    }
}


