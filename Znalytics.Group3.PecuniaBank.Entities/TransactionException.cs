using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities.TransactionException
{
    public class TransactionException : ApplicationException
    {
        /// <summary>
        /// Normal Constructor
        /// </summary>
        public TransactionException() : base() { }

        public TransactionException(string message) : base(message)
        {

        }

        public TransactionException(string message, Exception innerException) : base(message, innerException)
        {


        }

    }
}
