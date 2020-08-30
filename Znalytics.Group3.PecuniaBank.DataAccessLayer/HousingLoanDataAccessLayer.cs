using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.Remoting;
using Znalytics.Group3.PecuniaBank.AccountEntities;


namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DataAccessLayer for HousingLoan
    /// </summary>
    public interface IHousingLoanDataAccessLayer
    {
        void Add(HousingLoan n);
        void UpdateHousingLoan(HousingLoan u);
    }
    public class HousingLoanDataAccessLayer:IHousingLoanDataAccessLayer
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
        public void Add(HousingLoan n)
        {

            _housingLoans.Add(n);

        }
        //GetCustomerId
        public List<HousingLoan> GetCustomerId()
        {
            return _housingLoans;
        }
        //UpdateCustomerIds
        public void UpdateHousingLoan(HousingLoan u)
        {
            HousingLoan cust = _housingLoans.Find(temp => temp.CustomerId == u.CustomerId);
            if (cust !=null)
            {
                cust.CustomerId =u.CustomerId;
          
            }
        }
    }
}