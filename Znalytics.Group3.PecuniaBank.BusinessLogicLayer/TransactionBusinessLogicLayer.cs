
//VAMSHI JANGITI BUSINESS LOGIC LAYER

using System;
using System.Collections.Generic;
using System.Linq;

using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer.IAccountDetails;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.Group3.PecuniaBank.Entities.TransactionException;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    /// <summary>
    /// Business Logic Layer For WithDrawl And Debit
    /// </summary>
    public class TransactionBusinessLogic : ApplicationException//, ITransactionBLL
    {
        //creating objects for other classes
        ITransactionDAL transactionDAL;
        IAccountsBusinessLogic accountsBusinessLogic;

        /// <summary>
        /// Constructor for BLL
        /// </summary>
        public TransactionBusinessLogic()
        {
            transactionDAL = new TransactionDAL();
            accountsBusinessLogic = new AccountDetailBLLFake();
        }

        /// <summary>
        ///passing the object to the DAL
        /// </summary>
        /// <param name="t1">object</param>
        public void AddTranscation(Transaction t1)
        {
            try
            {
                if (t1 != null)
                {
                    //check account exist or not
                    AccountDetailBLLFake account = accountsBusinessLogic.GetAccountByAccountNumber(t1.AccountNumber);
                    if (account != null)
                    {
                        transactionDAL.AddTransaction(t1);
                    }
                }

                else
                {
                    throw new TransactionException("Wrong Data ");
                }
            }
            catch (TransactionException ex) when (ex.Message == "No Data Entered")
            {
                throw;
            }
            catch (TransactionException e)
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
                if (Regex.IsMatch(accNumber, "^[0-9]*$"))

                {

                    return 3;

                }
                else if (accNumber.Contains(" "))

                {
                    return 5;
                }

                else
                {
                    return 2;//more than 3
                }
            }
            else
            {
                return 4;//all includes
            }
        }


        public bool CheckAccountNumber(long accountNumber)
        {
            AccountDetailBLLFake account = accountsBusinessLogic.GetAccountByAccountNumber(accountNumber);
            if (account != null)
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
        /// Adding the Deposited Amount
        /// </summary>
        /// <param name="transactionAccno">Account NUmber</param>
        /// <param name="trascactioAmount">Amount</param>
        public void Deposit(Transaction t)
        {
            //transactionDAL.DepositAmount(transactionAccno, trascactioAmount);
            AccountDetailBLLFake result = accountsBusinessLogic.GetAccountByAccountNumber(t.AccountNumber);
            if (result != null)
            {

            }
            else
            {
                //  transactionDAL.Deposit(t);
                AccountDetailBLLFake ac = accountsBusinessLogic.GetAccountByAccountNumber(t.AccountNumber);
                //ac.Balance += t.TransactionAmount;
            }
        }



        /// <summary>
        /// Adding the WithDrawl Amount
        /// </summary>
        /// <param name="t2">Transaction Object</param>
        public int WithDrawlAmount(Transaction t)
        {

            AccountDetailBLLFake w = accountsBusinessLogic.GetAccountByAccountNumber(t.AccountNumber);
            if (w == null)
            {
                return 3;//No Data
            }
            /*  else
              {
                  if (w.Balance < t.TransactionAmount)
                  {
                      return 2;//Amount is Exceeded
                  }
                  else
                  {
                      w.Balance -= t.TransactionAmount;//WithDrawls the Amount
                      return 1;
                  }
            */
            return 1;
            //}
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
            if (t.TransactionAmount <= 100000)//&& t.TransactionAmount >= 500)
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
        /*   public bool TypeCheck(string tType, long accoun)
            {
               bool y = transactionDAL.TypeChecking(tType, accoun);
                //if both Conditions become true then the amount will be deposited
                return y;
            }*/




        /// <summary>
        /// Validattion Method for Current Account Transaction --- should not Exceed more than 5 lakh
        /// </summary>
        /// <param name="tType">Type Of Transaction</param>
        /// <param name="tAmount">Transaction Amount</param>
        /// <returns></returns>
        public bool WithDrawlTransactionValidation(Transaction t)
        {
            if (t.TransactionAmount <= 100000)// && t.TransactionAmount >= 500)
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
        /*  public double GetAmount(long acc)
          {
              return transactionDAL.GetAvailableBalance(acc);
          }



          /// <summary>
          /// Represents the Account Number from Accounts class
          /// </summary>
          /// <param name="acc">Account Number</param>
          /// <returns></returns>
          public bool GetAccountNumber(long acc)
          {
              return transactionDAL.GetAccountNumber(acc);
          }
       */
    }
}




