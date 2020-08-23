//NAVYA personalloandataaccesslayer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;


namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// Data access layer for Personalloan
    /// </summary>
    public class PersonalLoanDataAccessLayer
    {
        
        private static List<PersonalLoan> _personalLoans;
        static PersonalLoanDataAccessLayer()
        {
            _personalLoans = new List<PersonalLoan>()
            {
              new PersonalLoan () {AccountId ="12345",AccountNumber="123456",Tenure =3,AnnualIncome= 40000,LoanAmount =500000,CreditScore =650}
            };
        }
        public void AddAccountDetails(PersonalLoan pl)
        {
            _personalLoans.AddPersonalLoan(pl);

        }
           
    

            
       
      
            

        






    }
}
