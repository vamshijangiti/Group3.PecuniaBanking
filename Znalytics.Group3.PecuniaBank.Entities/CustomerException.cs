using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.PecuniaBanking.CustomerModule.Entities
{
    public class CustomerException : ApplicationException
    {
        /// <summary>
        /// exception class for Customer
        /// </summary>
        public CustomerException() : base()//exception which calls the parent exception
        {
        }
        public CustomerException(string message) : base(message)// displays exeception what user is defined
        {
            
        }
        public CustomerException(string message, Exception innerException) : base(message)//inner exeption is the exception throws from anthor class
        {
            
        }


    }
}