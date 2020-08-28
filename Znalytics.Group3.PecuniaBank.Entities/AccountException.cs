using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{
    /// <summary>
    /// Exception class for Accounts
    /// </summary>
    public class AccountException : ApplicationException
    {
        ///<summary>
        ///Constructor Intializes Nothing
        ///</summary>
        public AccountException() : base()
        {

        }
        ///<summary>
        ///Exception Which includes A message
        ///</summary>
        ///<param name="message"></param>
        public AccountException(string message) : base(message)
        {

        }
        ///<summary>
        ///AccountException Constructor intializes both message and innerException
        ///</summary>
        ///<param name="message"><</param>
        ///<param name="innerException"></param>
        public AccountException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
