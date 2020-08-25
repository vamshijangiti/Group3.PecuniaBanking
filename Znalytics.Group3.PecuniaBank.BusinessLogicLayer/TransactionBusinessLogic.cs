
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
    public interface ITransactionBLL
    {
        long ValidateAccountNumber(long accNumber);

    }


    /// <summary>
    /// Business Logic Layer For WithDrawl And Debit
    /// </summary>

    public class TransactionBusinessLogic : ITransactionBLL
    {
        ITransactionBLL transactionBll = new TransactionBusinessLogic();
        ITransactionDAL transactionDAl = new TransactionDAL();
        Transaction transaction = new Transaction();



        /// <summary>
        /// Validation Of AccountNumber
        /// </summary>
        /// <param name="_accNumber">Account Number Of Customer should Be Less than 10</param>
        /// <returns></returns>
        public long ValidateAccountNumber(long accNumber)
        {
            //if (_name.Length > 10)
            string l = accNumber + "";
            if (l.Length == 16)
            {

                transactionDAl.GetTransactions(accNumber);
                return accNumber;
            }
            else
            {
                throw new Exception(" \nplease check Account number \n");
            }
        }

        /// <summary>
        /// Validation For Withdrawl - minimum balance is 5000
        /// </summary>
        /// <param name="d1">Available Balance</param>
        /// <param name="d2">Entered Balance</param>
        /// <returns></returns>
        public bool ValidateWithDrawl(double d1, double d2)
        {
            if (d1 - d2 >= 5000)
            {
                //
                return true;
            }
            else
            {
                //Minimum Balance is 5000
                throw new Exception("\n Minimum Balance is 5000 ");

            }
        }


        /// <summary>
        /// Validation For Deposit - should be greater than 500
        /// </summary>
        /// <param name="d2">The Deposit Amount </param>
        /// <returns></returns>
        public bool ValidateDeposit(double d2)
        {

            if (d2 >= 500)
            {
                // Transaction.TransactionAmount = d2;
                return true;
            }
            else
            {
                //The Deposit Should be More Than 500 rs
                return false;
            }
        }
        /// <summary>
        /// Represents the Method for Deposit
        /// </summary>
        /// <param name="t1"></param>
        public void Deposit(Transaction t1)
        {

            transactionDAl.Deposit(t1);

        }

        /// <summary>
        /// Represents the Withdrawl Method
        /// </summary>
        /// <param name="t2"></param>

        public void WithDrawl(Transaction t2)
        {
            transactionDAl.WithDrawl(t2);
        }
    }
}


