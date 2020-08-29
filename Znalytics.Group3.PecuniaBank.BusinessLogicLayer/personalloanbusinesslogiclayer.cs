//NAVYA personalloanbusinesslogiclayer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    /// <summary>
    /// Business logic layer for personalloan
    /// </summary
    public class PersonalLoanBusinessLogicLayer
    {
        PersonalLoanDataAccessLayer personalLoanData =new PersonalLoanDataAccessLayer();
        PersonalLoanEntity PersonalLoan = new PersonalLoanEntity();
       
        public void AddPersonalLoan(PersonalLoanEntity pl)
        {
            personalLoanData.AddPersonalLoan(pl);
        }

        /* public void AddAccountDetails(PersonalLoanEntity pl)
          {
              _personalLoanDataAccessLayer.AddAccountDetails(pl);


          }*/
        public void CalculateEmi(float loan, float tenure)
        {
            if ((PersonalLoan.AccountNumber != null) && (PersonalLoan.LoanAmount != 0) && (PersonalLoan.Tenure != 0) && (PersonalLoan.CreditScore != 0))
            {
                PersonalLoan.Emi = EmiCalculation();

                float EmiCalculation()
                {
                    float emi;
                    float r = PersonalLoan.RateOfInterest / (12 * 100); // one month interest 
                    PersonalLoan.Tenure = PersonalLoan.Tenure * 12; // one month period 
                    emi = (PersonalLoan.LoanAmount * r * (float)Math.Pow(1 + r, PersonalLoan.Tenure))/ (float)(Math.Pow(1 + r, PersonalLoan.Tenure) - 1);

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













