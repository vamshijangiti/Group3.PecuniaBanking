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
   public  class PersonalLoanBusinessLogicLayer
    {
        PersonalLoanDataAccessLayer ab = new PersonalLoanDataAccessLayer();
        public void AddAccountDetails(PersonalLoan pl)
        { ab.AddAccountDetails(pl);


        }
            

       
       
    }
}
