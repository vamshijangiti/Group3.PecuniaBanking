using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    public interface ICustomerBLL
    {
        long GetAccountNumber(long AccountNumber);
    }
    public class CustomerBLL:ICustomerBLL
    {
        public long GetAccountNumber(long AccountNumber)
        {
            return 0;
        }
    }
}
