using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.Entities
{

    public class VehicleLoanException : ApplicationException
    {
        public VehicleLoanException() : base()
        {

        }
        public VehicleLoanException(string message) : base(message)
        {

        }
        public VehicleLoanException(string message, Exception innerException) : base(message)
        {

        }

    }


}
