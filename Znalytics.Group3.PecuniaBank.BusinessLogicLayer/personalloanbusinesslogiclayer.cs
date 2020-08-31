//NAVYA personalloanbusinesslogiclayer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    /// <summary>
    /// Business logic layer for personalloan
    /// </summary
    public class PersonalLoanBusinessLogicLayer
    {
        PersonalLoanDataAccessLayer personalLoanData = new PersonalLoanDataAccessLayer();
        PersonalLoanEntity personalLoan = new PersonalLoanEntity();

        public void AddPersonalLoan(PersonalLoanEntity pl)
        {
            personalLoanData.AddPersonalLoan(pl);

        }


        public int CreditScore(int credit)
        {
            if (credit >= 650)
            {
                return 1;
            }
            else if (credit > 600 || credit < 650)
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
        public float CalculateEmi(float tenure, float loan)
        {
            if ((loan != 0) && (tenure != 0))
            {
                // personalLoan.Emi = CalculateEmi();


                float emi;
                float r = personalLoan.RateOfInterest / (12 * 100); // one month rate of interest it is a static value
                tenure = tenure * 12; // one month period 
                emi = (loan * r * (float)Math.Pow(1 + r, tenure)) / (float)(Math.Pow(1 + r, tenure) - 1);

                return emi;
            }
            else
            {
                return 0;
                throw new Exception("Please check and Enter the valid values");
            }


        }

    }
}















