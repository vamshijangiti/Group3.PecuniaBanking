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

        public void CalculateEmi(VehicleLoan vl)
        {
            if ((vl.AccountNumber != null) && (vl.LoanAmount != 0D) && (vl.Tenure != 0D) && (vl.RateOfInterest != 0D) && (vl.CreditScore != 0))
            {
                vl.Emi = EmiCalculation();

                double EmiCalculation()
                {


                    double a = (vl.RateOfInterest) / (12 * 100); // one month interest 
                    vl.Tenure = (vl.Tenure) * 12; // one month period 
                    double p = ((vl.LoanAmount) * a * (float)Math.Pow(1 + a, (vl.Tenure)))
                             / (float)(Math.Pow(1 + a, (vl.Tenure) - 1));

                    return p;

                }
            }
            else
            {
                //throw new Exception("cvvvvvvvvv");
            }


        }
    }
}

           








    }

}

