﻿

//CREATED BY VAMSHI JANGITI -- DATA ACCESS LAYER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    public interface ICustomerPersonalDetailBLL
    {
        long GetAccountNumber();
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
