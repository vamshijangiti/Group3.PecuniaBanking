//NAVYA vehicleloanbusinesslogiclayer
using System;
using System.Collections.Generic;

using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    /// <summary>
    /// Business logic layer for Vehicleloan
    /// </summary
    public class VehicleLoanBusinessLogicLayer
    {
        VehicleLoanDataAccessLayer vehicleLoanData = new VehicleLoanDataAccessLayer();
        VehicleLoanEntity VehicleLoan = new VehicleLoanEntity();

        public void AddVehicleLoan(VehicleLoanEntity vl)
        {
            vehicleLoanData.AddVehicleLoan(vl);
        }

        /* public void AddAccountDetails(VehicleLoanEntity pl)
          {
              _vehicleLoanDataAccessLayer.AddAccountDetails(pl);


          }*/
        public void CalculateEmi(float loan, float tenure)
        {
            if ((VehicleLoan.AccountNumber != null) && (VehicleLoan.LoanAmount != 0) && (VehicleLoan.Tenure != 0) && (VehicleLoan.CreditScore != 0))
            {
                VehicleLoan.Emi = EmiCalculation();

                float EmiCalculation()
                {
                    float emi;
                    float r = VehicleLoan.RateOfInterest / (12 * 100); // one month interest 
                    VehicleLoan.Tenure = VehicleLoan.Tenure * 12; // one month period 
                    emi = (VehicleLoan.LoanAmount * r * (float)Math.Pow(1 + r, VehicleLoan.Tenure)) / (float)(Math.Pow(1 + r, VehicleLoan.Tenure) - 1);

                    return emi;

                }
            }
            else
            {
                //throw new Exception(");
                throw new Exception("Please check and Enter the valid values");
            }


        }

    }
}
























