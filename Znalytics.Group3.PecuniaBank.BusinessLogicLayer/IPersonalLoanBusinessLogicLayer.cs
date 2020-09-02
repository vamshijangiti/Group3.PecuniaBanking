using System;
using System.Collections.Generic;
using System.Linq;

using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    /// <summary>
    /// Interface for PersonalLoanBusinessLogicLayer
    /// </summary>
    interface IPersonalLoanBusinessLogicLayer
    {
        int CreditScore(PersonalLoanEntity p);
        float CalculateEmi(PersonalLoanEntity p);
        void AddPersonalLoan(PersonalLoanEntity pl);
    }
}
