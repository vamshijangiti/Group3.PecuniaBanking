using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.Remoting;
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
                new HousingLoan() {CustomerId=1,CustomerAge=25,Tenure=3,LoanAmount=21000,CreditScore=456 };
                new HousingLoan() {CustomerId=2,CustomerAge=24,Tenure=1.8,LoanAmount=24444,CreditScore=660};

            };
        }

        //Add CustomerId
        public void Add(HousingLoan customerid)
        {

            _housingLoans.Add(customerid);

        }
        //GetCustomerId
        public List<HousingLoan> GetCustomerId()
        {
            return _housingLoans;
        }
        //UpdateCustomerIds
        public void UpdateHousingLoan(HousingLoan customerId)
        {
            HousingLoan cust = _housingLoans.Find(temp => temp.CustomerId == customerId.CustomerId);
            if (cust !=null)
            {
                cust.CustomerId = customerId.CustomerId;
          
            }
        }
    }
}