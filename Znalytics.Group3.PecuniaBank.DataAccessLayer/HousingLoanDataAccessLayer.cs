using System.Collections.Generic;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DataAccessLayer for HousingLoan
    /// </summary>
    public class HousingLoanDataAccessLayer
    {
        //private fields
        private static List<HousingLoan> _housingLoans;

        //constructor
        static HousingLoanDataAccessLayer()
        {
            _housingLoans = new List<HousingLoan>();

            {
                new HousingLoan() { CustomerId =1, CustomerAge=24,Tenure=1,CreditScore=677 };
                new HousingLoan() { CustomerId = 2, CustomerAge = 25, Tenure = 3,CreditScore=360 };

            };
        }

        //Add Housing Loan Customer id
        public void Add(HousingLoan customerid)
        {

            _housingLoans.Add(customerid);//customerids
            _housingLoans.Add(customerid);

        }
        //GetCustomerId
        public List<HousingLoan> GetCustomerId()
        {
            return _housingLoans;
        }
        //UpdateHousingLoan
        public void UpdateHousingLoan(HousingLoan customerId)
        {
            HousingLoan cust = _housingLoans.Find(temp => temp.CustomerId == customerId.CustomerId);
            if (cust !=null)
            {
                cust.CustomerId = cust.CustomerId;
            }
        }
    }
}