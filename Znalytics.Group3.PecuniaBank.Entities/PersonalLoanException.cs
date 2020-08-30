using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{
    
        public class PersonalLoanException:ApplicationException
        {
            public PersonalLoanException():base()
            {

            }
            public PersonalLoanException (string message):base(message)
            {

            }
            public PersonalLoanException (string message,Exception innerException):base(message)
            {

            }

        }
          
    
}
