using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.DataAccessLayer
{
    public interface ICustomerPersonalDetailDAL
    {
        void AddCustomer(CustomerPersonalDetail customer);
        void ViewCustomer(CustomerPersonalDetail customer);
        void UpdateCustomer(CustomerPersonalDetail customer);

    }
}


