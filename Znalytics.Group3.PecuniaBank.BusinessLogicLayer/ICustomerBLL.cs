﻿

//CREATED BY Manasa -- 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.PecuniaBanking.CustomerModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.BusinessLogicLayer.ICustomer
{
    /// <summary>
    /// Represents interface for Customer Personal Detail Businesslogiclayer
    /// </summary>
    public interface ICustomerBLL
    {


        //Viewing existing details
        public List<Customer> GetCustomers();

        public Customer GetCustomersByCustomerId(int CustomerId);
        

    }
    
}