using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    public interface ICustomer
    {
        long GetAccountNumber(long accNumber);

    }
    public class CustomerDetail : ICustomer
    {
       public long GetAccountNumber(long accNumber)
        {
            return 0;
        }

    }
}
