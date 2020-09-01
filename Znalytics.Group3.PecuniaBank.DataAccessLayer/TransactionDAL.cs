
//CREATED BY VAMSHI JANGITI -- DATA ACCESS LAYER


using System;
using System.Collections.Generic;
using Znalytics.Group3.PecuniaBank.Entities;
using Newtonsoft.Json;
using System.IO;
using Znalytics.Group3.PecuniaBank.Entities.TransactionException;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DAL Class For WithDrawl And Deposit
    /// </summary>
    public class TransactionDAL : ApplicationException, ITransactionDAL
    {

        static List<Transaction> _transactionsList;///list For Transaction Entity

        static TransactionDAL() // creating a list object in constructor
        {
            _transactionsList = new List<Transaction>();
            if (_transactionsList.Count == 0)
            {
                _transactionsList = LoadDataFromFile();
            }
        }


        /// <summary>
        /// Adding the object in to List
        /// </summary>
        /// <param name="t">object</param>
        public void AddTransaction(Transaction t)
        {
            //Generating the TransactionID 
            int max = 0;
            foreach (var item in _transactionsList)
            {
                if (item.TransactionID > max)
                {
                    max = item.TransactionID;
                }
            }
            t.TransactionID = ++max;
            if (_transactionsList.Count != 0)
            {
                _transactionsList.Add(t);
                SaveDataInToFile();
            }
            else
            {
                throw new TransactionException("No Data Entered");
            }
        }


        /// <summary>
        /// Returning Transactions List-- By checking the AccountNumber
        /// </summary>
        /// <param name="Accoun">Account Nummber</param>
        /// <returns>The List Of Transactions</returns>
        public List<Transaction> GetTransactionList(long accountNumber)
        {
            List<Transaction> _list1 = _transactionsList.FindAll(temp => temp.AccountNumber == accountNumber);//It Finds all the list and Returns List
            return _list1;
        }

        /// <summary>
        /// Writing the Data into File
        /// </summary>
        public void SaveDataInToFile()
        {

            string s = JsonConvert.SerializeObject(_transactionsList);//Converting to Json file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\Transactions.txt");//Writes the Data in to File
            streamWriter.Write(s);//Writes the Data 
            streamWriter.Close();//Closing the File
        }


        /// <summary>
        /// Reading the Data from file
        /// </summary>
        /// <returns>List of Transactions</returns>
        public static List<Transaction> LoadDataFromFile()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\Transactions.txt");//Reading the Data From File
            string st = streamReader.ReadToEnd();//Reads the Data Upto End
            List<Transaction> _transactions = JsonConvert.DeserializeObject<List<Transaction>>(st);//Converting from Json File 
            streamReader.Close();//Closing the File
            return _transactions;//Returning the Transactions

        }

    }
}
