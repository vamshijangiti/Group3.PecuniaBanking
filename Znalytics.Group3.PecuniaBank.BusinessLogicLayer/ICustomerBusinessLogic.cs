using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.PecuniaBanking.CustomerModule.Entities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    interface  ICustomerBusinessLogic
    {
        /// List that contains customer details
        /// </summary>
        /// <returns>list of customers</returns>
        public List<Customer> GetCustomers();

        /// <summary>
        /// Method to the Get the customer details by customer Id
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns>customerdeatils</returns>
        public Customer GetCustomersByCustomerId(int CustomerId);


    }

}

