
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
using System.IO;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DAL Class For WithDrawl And Deposit
    /// </summary>
    public class TransactionDAL : ITransactionDAL
    {

        static List<Transaction> _transactionList = new List<Transaction>();//list For Transaction Entity


        /// <summary>
        /// Adding the object in to List
        /// </summary>
        /// <param name="t">object</param>
        public void AddTransaction(Transaction t)
        {
            /*int max = _transactionList.Max(temp => temp.TransactionID);
           t.TransactionID = max;
           */
            int max = 0;
            foreach (var item in _transactionList)
            {
                if (item.TransactionID > max)
                {
                    max = item.TransactionID;
                }
            }
            t.TransactionID = ++max;
            _transactionList.Add(t);
            SavingData();

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
                SavingData();
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
                    SavingData();
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

            List<Transaction> list1 = _transactionList.FindAll(temp => temp.AccountNumber == Accoun);
            GettingFile();
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
                GettingFile();
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
            GettingFile();
            return result.balance;
        }


        /// <summary>
        /// Getting the Account Number from the Accounts
        /// </summary>
        /// <param name="Accoun">Represents the Account Number</param>
        /// <param name="dALs">List from the Accounts</param>
        /// <returns></returns>
        public bool GetAccountNumber(long account, List<AccountDAL> _dALs)
        {
            AccountDAL result = _dALs.SingleOrDefault(temp => temp.accno == account); //SingleOrDefault is used to returns the single element
            if (result == null)
            {
                return false;
                //  throw new TransactionException();
            }
            else
            {
                GettingFile();
                return true;

            }
        }



        public void SavingData()
        {

            string s = JsonConvert.SerializeObject(_transactionList);
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\Transactions.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }

        public static List<Transaction> GettingFile()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\Transactions.txt");
            string st = streamReader.ReadToEnd();
            List<Transaction> _transactions = JsonConvert.DeserializeObject<List<Transaction>>(st);
            streamReader.Close();
            return _transactions;

        }

    }
}
