//NAVYA personalloandataaccesslayer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.HousingLoanEntities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer

{
    /// <summary>
    /// Data access layer for Personalloan
    /// </summary>
    public class PersonalLoanDataAccessLayer
    {

        static List<PersonalLoanEntity> _personalLoans = new List<PersonalLoanEntity>();
        public void AddPersonalLoan(PersonalLoanEntity p)
        {
            _personalLoans.Add(p);
        }



    }
}
