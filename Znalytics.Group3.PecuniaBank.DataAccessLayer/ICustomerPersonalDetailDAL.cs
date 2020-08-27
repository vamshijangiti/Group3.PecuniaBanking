
//Done by Manasa

using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.DataAccessLayer
{
    /// <summary>
    /// Represents interface for the customer Personal Detail DataAccessLayer
    /// </summary>
    public interface ICustomerPersonalDetailDAL
    {
        //Adding customer details
        void AddCustomer(CustomerDetail customer);
        //Viewing details
        // void ViewCustomer(CustomerPersonalDetail customer);
        // Updating details of customer
        public List<CustomerDetail> GetCustomers()
        {
           // return cdal.GetCustomers();
        }

        void UpdateCustomer(CustomerDetail customer);

    }
}


