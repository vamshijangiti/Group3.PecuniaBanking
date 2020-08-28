

//CREATED BY Manasa -- 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.PecuniaBanking.CustomerDetailModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.BusinessLogicLayer
{
    /// <summary>
    /// Represents interface for Customer Personal Detail Businesslogiclayer
    /// </summary>
    public interface ICustomerDetailBLL
    {

        //Viewing existing details
        void GetCustomers(CustomerDetail customer);

        customer GetCustomerByCustomerNameByCustomerId(string CustomerID);

    }
    
}