using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.Remoting;
using Znalytics.Group3.PecuniaBank.HousingLoanBusinessLogicLayer;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DataAccessLayer for HousingLoan
    /// </summary>
    public class HousingLoanDataAccessLayer
    {
        //private fields
        private static List<Housingloan> housingloans;

        //constructor
        static HousingLoanDataAccessLayer()
        {
            _housingLoans = new List<HousingLoan>();

            {
                new () { CustomerAccountNo = 135792468012, CustomerName = "sri" };
                new Customer() { CustomerAccountNo = 123456789013, CustomerName = "ram" }

            };
        }

        //Add Customers
        public void Add(HousingLoan customerid)
        {

            _customers.Add(customer);

        }
        //Getcustomers
        public List<Customer> GetCustomers()
        {
            return _customers;
        }
        //UpdateCustomers
        public void UpdateCustomer(Customer customer)
        {
            customer cust = _customers.Find(temp => temp.CustomerAccountNo == customer.CustomerAccountNo);
            if (cust !=null)
            {
                cust.CustomerName = customer.CustomerName;
            }
        }
    }
}