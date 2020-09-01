using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    interface IVehicleLoanBusinessLogicLayer
    {
        int CreditScore(VehicleLoanEntity p);
        float CalculateEmi(VehicleLoanEntity p);
        void AddPersonalLoan(VehicleLoanEntity pl);

    }
}
