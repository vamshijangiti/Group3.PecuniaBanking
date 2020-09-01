using System;
using System.Collections.Generic;
using System.Linq;

using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    interface IPersonalLoanBusinessLogicLayer
    {
        int CreditScore(PersonalLoanEntity p);
        float CalculateEmi(PersonalLoanEntity p);
        void AddPersonalLoan(PersonalLoanEntity pl);
    }
}
