
//VAMSHI JANGITI DATA ACCESS LAYER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DataAccessLayer For WithDrawl And Debit
    /// </summary>
    public  class TransactionDAL
    {
       // Transaction transaction = new Transaction();

        List<Transaction> transactions = new List<Transaction>();
        
       
        /// <summary>
        /// Adding the AccountNumber in to List
        /// </summary>
        /// <param name="t">Account Number</param>
        public void AddAccountNumber(Transaction t)
        {
            transactions.Add(t);
        }


    }
}
