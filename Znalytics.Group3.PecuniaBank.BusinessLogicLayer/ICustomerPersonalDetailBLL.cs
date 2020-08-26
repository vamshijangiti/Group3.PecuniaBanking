

//CREATED BY Manasa -- 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities;

namespace Znalytics.Group3.PecuniaBanking.BusinessLogicLayer
{
    /// <summary>
    /// Represents interface for Customer Personal Detail Businesslogiclayer
    /// </summary>
    public interface ICustomerPersonalDetailBLL
    {
        //Adding details
        void AddCustomer(CustomerPersonalDetail customer);

        //Viewing existing details
        void ViewCustomer(CustomerPersonalDetail customer);

        //customer GetCustomerByCustomerId(string CustomerID);

        //Updating customer details
        void UpdateCustomer(CustomerPersonalDetail customer);
    }
    
}