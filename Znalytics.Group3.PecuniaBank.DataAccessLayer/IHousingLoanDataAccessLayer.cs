using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using Znalytics.Group3.PecuniaBank.HousingLoanEntities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
  
         interface IHousingLoanDataAccessLayer
        {
            void Add( HousingLoan n);
            void RejectHousingLoan(HousingLoan u,int CreditScore);
        }
    }

