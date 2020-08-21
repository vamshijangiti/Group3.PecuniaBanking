
//CREATED BY VAMSHI JANGITI --ETITIES For WithaDarwl And Deposit

using System;
using System.Collections.Generic;
using System.Linq;
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
        private string _transactionDate;
        private string _transactionType;
        private string _trasactionAmount;
        private long _accountNumber;


        public Transaction() { }



        /// <summary>
        /// Constructor For Entity Class
        /// </summary>
        /// <param name="accountNumber">Account Number </param>
        /// <param name="date">Transactio Date</param>
        /// <param name="transactionID">Transaction ID</param>
        /// <param name="transactionType">Type Of Transaction</param>
        /// <param name="transactionAmount">Transaction Amount</param>
        public Transaction(long accountNumber, string date, int transactionID, string transactionType, string transactionAmount)
        {
            this._accountNumber = accountNumber;
            this._transactionDate = date;
            this._transactionID = transactionID;
            this._transactionType = transactionType;
            this._trasactionAmount = transactionAmount;
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
        public string TransactionDate
        {
            get
            { return _transactionDate; }
        }


        /// <summary>
        /// Represents the Type Of the Transaction
        /// </summary>
        public string TransactionType
        {
            set
            {
                _trasactionAmount = value;

            }
            get
            {
                return _transactionType;
            }
        }



    }
}
