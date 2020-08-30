
//Done by Manasa

using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CustomerModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.DataAccessLayer
{
    /// <summary>
    /// Represents interface for the customer Personal Detail DataAccessLayer
    /// </summary>
    public interface ICustomerDataAccessLayer
    {
        //Adding customer details
        void AddCustomer(Customer customer);
        //Viewing details
        // void ViewCustomer(CustomerPersonalDetail customer);
        // Updating details of customer
        List<Customer> GetCustomers();

        void UpdateCustomer(Customer customer);
        Customer GetCustomersByCustomerId(int CustomerId);
    }
}


