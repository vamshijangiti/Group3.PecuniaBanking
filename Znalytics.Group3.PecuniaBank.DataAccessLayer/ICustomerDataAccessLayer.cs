
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
        void AddCustomer(Customer customer);//calls add customer method
        List<Customer> GetCustomers();//calls get customers method

        void UpdateCustomer(Customer customer);//calls update customer method
        Customer GetCustomersByCustomerId(int CustomerId);//calls get customer by customer id
    }
}


