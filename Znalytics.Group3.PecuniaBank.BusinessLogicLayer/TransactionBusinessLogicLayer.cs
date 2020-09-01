
//VAMSHI JANGITI BUSINESS LOGIC LAYER

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.Group3.PecuniaBank.Entities.TransactionException;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{

    /// <summary>
    /// Business Logic Layer For WithDrawl And Debit
    /// </summary>
    public class TransactionBusinessLogic : ApplicationException, ITransactionBLL
    {
        //creating objects for other classes
        ITransactionDAL transactionDAL = new TransactionDAL();
        AccountDetailBLLFake account = new AccountDetailBLLFake();
        /// <summary>
        /// Constructor for BLL
        /// </summary>
        static TransactionBusinessLogic()
        { }


        /// <summary>
        ///passing the object to the DAL
        /// </summary>
        /// <param name="t1">object</param>
        public void AddTranscation(Transaction t)
        {
            try
            {
                if (account != null)
                {
                    AccountDetailBLLFake result = account.GetAccountByAccountNumber(t.AccountNumber);
                    if (result != null)
                    {
                        transactionDAL.AddTransaction(t);
                    }
                    else
                    {
                        throw new TransactionException("Wrong Data");
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }

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
            else if (accNumber.Length == 3)
            {
                if (Regex.IsMatch(accNumber, "^[0-9]*$"))//&& !Regex.IsMatch(accNumber,@"[A-Z][a-z]"))

                {
                    return 3;

                }
                else if (accNumber.Contains(" "))

                {
                    return 5;
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
        /// For Checking the Account Number
        /// </summary>
        /// <param name="accountNumber">Entered AccountNumber</param>
        /// <returns></returns>
        public bool CheckAccountNumber(long accountNumber)
        {
            AccountDetailBLLFake account = new AccountDetailBLLFake();
            if (account.Account == accountNumber)
            {
                return true;
            }
            else
            {
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
                return false;//The Deposit Should be More Than 500 rs
            }
        }

        /// <summary>
        /// Represents the Deposit Process
        /// </summary>
        /// <param name="t"></param>
        public void DepositAmount(Transaction t)
        {
            AccountDetailBLLFake a = new AccountDetailBLLFake();
            if (t.TransactionAmount < 100000 && t.TransactionAmount >= 500)
            {
                a.Balance += t.TransactionAmount;
            }
            else
            {

            }
        }

        /// <summary>
        ///Represents WithDrawl Amount
        /// </summary>
        /// <param name="t2">Transaction Object</param>
        public int WithDrawlAmount(Transaction t)
        {

            AccountDetailBLLFake result = new AccountDetailBLLFake();
            if (result == null)
            {
                return 3;
            }
            else
            {
                if (result.Balance < t.TransactionAmount)
                    return 2;
                else
                {
                    result.Balance -= t.TransactionAmount;
                    return 1;
                }
            }

        }




        /// <summary>
        /// List For Getting the Transaction details by AccountNumber from Other's Class
        /// </summary>
        /// <param name="AccountNumber">Account Number</param>
        /// <returns></returns>
        public List<Transaction> GetTransactions(long accountNumber)
        {

            List<Transaction> tx = null;
            tx = transactionDAL.GetTransactionList(accountNumber);
            return tx;
        }



        /// <summary>
        /// Validation For Savings--should not Exceed more than 1 lakh
        /// </summary>
        /// <param name="tamount">Entered Amount</param>
        /// <param name=" tType">Transaction type</param>
        /// <returns>if it exceeds 1 lakh returns false else true</returns>
        public bool DepositTransactionValidation(Transaction t)
        {
            //if both Conditions become true then the amount will be deposited
            if (t.TransactionAmount <= 100000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}



