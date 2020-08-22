//NAVYA vehicleloanbusinesslogiclayer
using System;
using System.Collections.Generic;

using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    
    /// <summary>
    /// Business logic layer for vehicle loan
    /// </summary>
    public class vehicleLoanBusinessLogicLayer

    {
        vehicleloandataaccesslayer cd = new vehicleloandataaccesslayer ();
        public void AddAccountDetails(VehicleLoan vl)
        {
            cd.AddAccountDetails(vl);


        }
    




    }

}

