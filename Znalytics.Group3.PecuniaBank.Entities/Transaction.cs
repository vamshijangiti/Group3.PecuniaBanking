
//ETITIES For WithaDarwl And Deposit

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

        // private string _date;

        private long _accountNumber;
        private double _balance;

        public Transaction() { }

        /// <summary>
        /// Entities Constructor
        /// </summary>
        /// <param name="_accountNumber">AccountNumber of Customer</param>
        /// <param name="_balance">Balance Of the Customer</param>
        public Transaction(long _accountNumber, double _balance)
        {
            this._accountNumber = _accountNumber;
            this._balance = _balance;
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


        public double Balance
        {
            set
            {
                _balance = value;
            }

            get
            {
                return _balance;
            }
        }


    }
}
