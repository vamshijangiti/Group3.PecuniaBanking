
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

        private string _transactionDate;
        private string _transactionType;
        private string _trasactionAmount;
        private long _accountNumber;


        public Transaction() { }

        /// <summary>
        /// Entities Constructor
        /// </summary>
        /// <param name="_accountNumber">AccountNumber of Customer</param>
        

        public Transaction(long accountNumber,string date)
        {
            this._accountNumber = accountNumber;
            this._transactionDate = date;
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
        public string TransactionDate { get; set; }


    }
}
