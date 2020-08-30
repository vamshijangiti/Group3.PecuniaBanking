
//CREATED BY VAMSHI JANGITI --Entity Layer For WithaDarwl And Deposit

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{

    /// <summary>
    /// Entity Layer For Transactions
    /// </summary>
    public class Transaction
    {
        private int _transactionID;
        private DateTime _transactionDate;
        private string _transactionType;
        private double _transactionAmount;
        private long _accountNumber;

        //Transaction transaction = new Transaction();

        public Transaction() { }



        /// <summary>
        /// Constructor For Entity Class
        /// </summary>
        /// <param name="accountNumber">Account Number </param>
        /// <param name="date">Transactio Date</param>
        /// <param name="transactionID">Transaction ID</param>
        /// <param name="transactionType">Type Of Transaction</param>
        /// <param name="transactionAmount">Transaction Amount</param>
        public Transaction(long accountNumber, DateTime date, int transactionID, string transactionType, double transactionAmount)
        {
            this._accountNumber = accountNumber;
            this._transactionDate = date;
            this._transactionID = transactionID;
            this._transactionType = transactionType;
            this._transactionAmount = transactionAmount;
        }


        /// <summary>
        ///Set Method For AccountNumber
        /// </summary>
        public long AccountNumber
        {
            set
            {
                _accountNumber = value;
            }
            get
            {
                return _accountNumber;
            }
        }

        /// <summary>
        /// Represents the Transaction Date
        /// </summary>
        public DateTime TransactionDate
        {
            set
            {
                _transactionDate = value;
            }
            get
            { return _transactionDate; }
        }


        /// <summary>
        /// Represents the Transaction Amount
        /// </summary>
        public double TransactionAmount
        {
            set
            {
                _transactionAmount = value;

            }
            get
            {
                return _transactionAmount;
            }
        }

        /// <summary>
        /// Represents the Method for Transaction Type
        /// </summary>
        public string TransactionTpe
        {
            set
            {
                _transactionType = value;

            }
            get
            {
                return _transactionType;
            }
        }

        /// <summary>
        /// Represents The Method For Transaction ID
        /// </summary>
        public int TransactionID
        {
            set
            {
                _transactionID = value;
            }
            get
            {
                return _transactionID;
            }
        }

    }
}
