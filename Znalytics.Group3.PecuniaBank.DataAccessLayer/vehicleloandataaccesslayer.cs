//NAVYA Dataaccesslayer for vehice loan
using System;
using System.Collections.Generic;

using Znalytics.Group3.PecuniaBank.Entities;
namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// Data access layer for vehicle loan
    /// </summary>
    public class vehicleloandataaccesslayer
    {
        private static List<VehicleLoan> _vehicleLoans;
        static vehicleloandataaccesslayer()
        {
            _vehicleLoans = new List<VehicleLoan>()
            {
              new VehicleLoan () {AccountId ="12345",AccountNumber="123456",Tenure =3,AnnualIncome= 40000,LoanAmount =500000,CreditScore =650}
            };
        }
        public void AddAccountDetails(VehicleLoan vl)
        {
            _vehicleLoans.AddsVehicleLoan(vl);

        }


    }
}
