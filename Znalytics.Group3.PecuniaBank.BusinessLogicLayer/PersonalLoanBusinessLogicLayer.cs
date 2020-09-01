//NAVYA personalloanbusinesslogiclayer
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
    public class PersonalLoanBusinessLogicLayer
    {
        PersonalLoanDataAccessLayer personalLoanData = new PersonalLoanDataAccessLayer();
        PersonalLoanEntity personalLoan = new PersonalLoanEntity();
        ICustomerBusinessLogicLayer i = new CustomerBusinessLogicLayer();

        public Customer GetCustomersByCustomerId(int c)
        {
            return i.GetCustomersByCustomerId(c);

        }

        public void AddPersonalLoan(PersonalLoanEntity pl)
        {
            personalLoanData.AddPersonalLoan(pl);

        }


        public int CreditScore(PersonalLoanEntity p)
        {
            if (p.CreditScore  >= 650)
            {
                return 1;
            }
            else if (p.CreditScore  > 600 || p.CreditScore < 650)
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
        public float CalculateEmi(PersonalLoanEntity p)
        {
            if ((p.LoanAmount != 0) && (p.LoanAmount >= 50000) && (p.Tenure != 0) && (p.Tenure >= 10))
            {
                // personalLoan.Emi = CalculateEmi();


                //float emi;
                float r = personalLoan.RateOfInterest / (12 * 100); // one month rate of interest it is a static value
                p.Tenure  = p.Tenure * 12; // one month period 
                p.Emi  = (p.LoanAmount * r * (float)Math.Pow(1 + r, p.Tenure)) / (float)(Math.Pow(1 + r, p.Tenure) - 1);

                return p.Emi;
            }
            else
            {
                return 0;
                //throw new Exception("Please check and Enter the valid values");
            }


        }

    }
}















