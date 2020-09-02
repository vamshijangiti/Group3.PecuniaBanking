//////////// Done by Manasa ////////////

using Znalytics.Group3.PecuniaBanking.DataAccessLayer;
using System;
using System.Linq;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CustomerModule.Entities;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.DataAccessLayer
{
    /// <summary>
    /// Represents Data Access Layer of customer which is child to the parent class of ICustomer data access layer
    /// </summary>
    public class CustomerDataAccessLayer : ICustomerDataAccessLayer
    {
        static List<Customer> _customers = new List<Customer>()//list of customer
                                                              
        {
            new Customer()//mock data
            {
                CustomerId=1,CustomerName="Manasa",MailId="manasa@gmail.com",Address="Hyderabad",Profession="aaa",AadharCardNumber="123456789876",PanCardNumber="asdfg1234r",PhoneNumber="1234567890",Age=20
            },
            new Customer()
            {
                CustomerId=2,CustomerName="Navya",MailId="navya@gmail.com",Address="Warangal",Profession="bbb",AadharCardNumber="193456789876",PanCardNumber="ahjfg1234r",PhoneNumber="9834567890",Age=21

            },
            new Customer()//mock data
            {
                CustomerId=3,CustomerName="Sriram",MailId="sriram@gmail.com",Address="Karimnagar",Profession="ccc",AadharCardNumber="123456788976",PanCardNumber="acgfg1234r",PhoneNumber="1234565674",Age=22
            },
            new Customer()
            {
                CustomerId=4,CustomerName="Vamshi",MailId="vamshi@gmail.com",Address="Vizag",Profession="ddd",AadharCardNumber="193454199876",PanCardNumber="agjkg1734n",PhoneNumber="9878567890",Age=23

            }

        };



        /// <summary>
        ///Method to  Add Customer Details 
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }


        /// <summary>
        /// Method to get existing Customer details
        /// </summary>
        /// <returns>existing customers</returns>
        public List<Customer> GetCustomers()
        {
            return _customers;
        }


        /// <summary>
        /// Method to Update of customer details
        /// </summary>
        /// <param name="c">c</param>

        public void UpdateCustomer(Customer c)
        {
            ///updating deatils based on customer id///
            Customer cu = _customers.Find(temp => temp.CustomerId == c.CustomerId);
            if (cu != null)
            {
                cu.CustomerName = c.CustomerName;

            }
        }

        /// <summary>
        /// Method to get customers details by CustomerId
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public Customer GetCustomersByCustomerId(int CustomerId)//Displaying product Details using Product ID
        {
            Customer e;
            e = _customers.Find(n => n.CustomerId == CustomerId);

            return e;
        }
    }
}