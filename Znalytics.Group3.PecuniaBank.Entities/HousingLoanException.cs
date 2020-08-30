using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.AccountEntities
{
    /// <summary>
    /// Housingloan Exception 
    /// </summary>
   public  class HousingLoanException:ApplicationException
    {
        /// <summary>
        /// default constructor with no message
        /// </summary>
        public HousingLoanException():base()
        {

        }
        /// <summary>
        /// constructor intializes HousingLoanException with a message
        /// </summary>
        /// <param name="message"></param>
        public HousingLoanException(string message):base(message)
        {

        }
        /// <summary>
        /// constructor intializes HousingLoanException with a innerException and message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public HousingLoanException(string message,Exception innerException):base(message,innerException)
        {

        }
    }
}
