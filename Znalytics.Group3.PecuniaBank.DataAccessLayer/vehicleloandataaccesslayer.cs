//NAVYA Dataaccesslayer for vehice loan
using System;
using System.Collections.Generic;

using Znalytics.Group3.PecuniaBank.Entities;
namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// Data access layer for vehicle loan
    /// </summary>
    public class VehicleLoanDataAccessLayer
    {
        private static List<PersonalLoan> _vehicleLoans;
        static VehicleLoanDataAccessLayer()
        {
            _vehicleLoans = new List<PersonalLoan>()
            {
              new PersonalLoan ()
              {AccountNumber ="12345",Tenure =3,LoanAmount =500000,CreditScore =650}
            };
        }
        public void AddAccountDetails(PersonalLoan vl)
        {
            _vehicleLoans.AddsVehicleLoan(vl);

        }


    }
}
