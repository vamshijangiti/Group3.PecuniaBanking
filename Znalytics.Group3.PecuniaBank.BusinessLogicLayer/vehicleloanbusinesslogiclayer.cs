//NAVYA vehicleloanbusinesslogiclayer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.PecuniaBanking.CustomerModule.Entities;
using Znalytics.Group3.PecuniaBanking.BusinessLayer;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    /// <summary>
    /// Business logic layer for personalloan
    /// </summary
    public class VehicleLoanBusinessLogicLayer
    {
        VehicleLoanDataAccessLayer vehicleLoanData = new VehicleLoanDataAccessLayer();
        VehicleLoanEntity vehicleLoan = new VehicleLoanEntity();
        ICustomerBusinessLogicLayer i = new CustomerBusinessLogicLayer();

        public Customer GetCustomersByCustomerId(int c)
        {
            return i.GetCustomersByCustomerId(c);

        }


        public void AddVehicleLoan(VehicleLoanEntity vl)
        {
            vehicleLoanData.AddVehicleLoan(vl);

        }


        public int CreditScore(VehicleLoanEntity v)
        {
            if (v.CreditScore >= 650)
            {
                return 1;
            }
            else if (v.CreditScore > 600 || v.CreditScore < 650)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        //calculation of emi
        //If account number,loan amount,tenure and credit score value not equals to null and 0 then emi is calculated
        public float CalculateEmi(VehicleLoanEntity v)
        {
            if ((v.LoanAmount != 0)&&(v.LoanAmount>=50000) && (v.Tenure != 0)&&(v.Tenure>=10))
            {
                // vehicleLoan.Emi = CalculateEmi();


                //float emi;
                float r = vehicleLoan.RateOfInterest / (12 * 100); // one month rate of interest it is a static value
                v.Tenure = v.Tenure * 12; // one month period 
               v.Emi = (v.LoanAmount * r * (float)Math.Pow(1 + r, v.Tenure)) / (float)(Math.Pow(1 + r, v.Tenure) - 1);

                return v.Emi;
                
            }
            else
            {
                return 0;
               // throw new Exception("Please check and Enter the valid values");
            
            }


        }

    }
}









