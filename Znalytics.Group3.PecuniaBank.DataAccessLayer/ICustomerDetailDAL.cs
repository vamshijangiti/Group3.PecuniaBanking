
//Done by Manasa

using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CustomerDetailModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.DataAccessLayer
{
    /// <summary>
    /// Represents interface for the customer Personal Detail DataAccessLayer
    /// </summary>
    public interface ICustomerDetailDAL
    {
        //Adding customer details
        void AddCustomer(CustomerDetail customer);
        //Viewing details
        // void ViewCustomer(CustomerPersonalDetail customer);
        // Updating details of customer
        void GetCustomers(CustomerDetail customer);

       // void UpdateCustomer(CustomerDetail customer);
       // List<CustomerDetail> GetCustomerNameByCustomerId(string customerName);
    }
}


