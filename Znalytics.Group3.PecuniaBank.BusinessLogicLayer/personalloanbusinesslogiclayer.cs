//NAVYA personalloanbusinesslogiclayer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.IPersonalLoan.BusinessLogicLayer;
namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    /// <summary>
    /// Business logic layer for personalloan
    /// </summary
   public  class PersonalLoanBusinessLogicLayer: IPersonalLoanBusinessLogicLayer
    {
        PersonalLoanDataAccessLayer _personalLoanDataAccessLayer;
        public PersonalLoanBusinessLogicLayer ()
        {
            _personalLoanDataAccessLayer = new PersonalLoanDataAccessLayer();

        }
       
        public void AddAccountDetails(PersonalLoan pl)
        {
            _personalLoanDataAccessLayer.AddAccountDetails(pl);


        }
        public void CalculateEmi(PersonalLoan pl)
        {
            if ((pl.AccountNumber != null) && (pl.LoanAmount != 0D) && (pl.Tenure != 0D) && (pl.RateOfInterest != 0D) && (pl.CreditScore != 0))
            {
                pl.Emi = EmiCalculation();

                double EmiCalculation()
                {


                    double a = (pl.RateOfInterest) / (12 * 100); // one month interest 
                    pl.Tenure = (pl.Tenure) * 12; // one month period 
                    double p = ((pl.LoanAmount) * a * (float)Math.Pow(1 + a, (pl.Tenure)))
                             / (float)(Math.Pow(1 + a, (pl.Tenure) - 1));

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

           





            
           




    
