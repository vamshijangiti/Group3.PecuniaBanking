//NAVYA Dataaccesslayer for vehice loan
using System;
using System.Collections.Generic;

using Znalytics.Group3.PecuniaBank.HousingLoanEntities;
namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// Data access layer for vehicle loan
    /// </summary>

    public class VehicleLoanDataAccessLayer
    {

        private static List<VehicleLoanEntity> _vehicleLoans = new List<VehicleLoanEntity>();
        public void AddVehicleLoan(VehicleLoanEntity v)
        {
            _vehicleLoans.Add(v);
        }
    }
}