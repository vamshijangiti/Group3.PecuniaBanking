

//CREATED BY VAMSHI JANGITI -- DATA ACCESS LAYER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    public interface ICustomerPersonalDetailBLL
    {
        void AddCustomer(CustomerPersonalDetail customer);
        Customer GetCustomerByCustomerId(string CustomerID);
    }
    public class CustomerBLL:ICustomerPersonalDetailBLL
    {
        public long GetAccountNumber()
        {
            return 0;
        }
    }
}

/*using System;
using Znalytics.OnlineShopping.CustomersModule.Entities;

namespace Znalytics.OnlineShopping.BusinessLogicLayer
{
    public interface ICustomerBusinessLogicLayer
    {
        void AddCustomer(Customer customer);
    }
}
