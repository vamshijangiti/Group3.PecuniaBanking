

//CREATED BY Manasa -- 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities;

namespace Znalytics.PecuniaBank.BusinessLogicLayer
{
    public interface ICustomerPersonalDetailBLL
    {
        void ViewCustomer(CustomerPersonalDetail customer);
        //customer GetCustomerByCustomerId(string CustomerID);
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
