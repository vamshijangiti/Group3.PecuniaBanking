//NAVYA Dataaccesslayer for vehice loan
//NAVYA Dataaccesslayer for vehice loan
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer

{
    /// <summary>
    /// Data access layer for Vehicleloan
    /// </summary>
    public class VehicleLoanDataAccessLayer
    {

        private static List<VehicleLoanEntity> _vehicleLoans;
        static VehicleLoanDataAccessLayer()
        {
            _vehicleLoans = new List<VehicleLoanEntity>();
            _vehicleLoans = LoadDetailsToList();
        }



        public void AddVehicleLoan(VehicleLoanEntity v)
        {
            _vehicleLoans.Add(v);
            ListOfVehicleLoanEntity();
        }
        public void ListOfVehicleLoanEntity()
        {
            string s = JsonConvert.SerializeObject(_vehicleLoans);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\VehicleLoan\Vehicle.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        public static List<VehicleLoanEntity> LoadDetailsToList()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\VehicleLoan\Vehicle.txt");
            string s2 = streamReader.ReadToEnd();
            List<VehicleLoanEntity> VehicleLoans = JsonConvert.DeserializeObject<List<VehicleLoanEntity>>(s2);
            streamReader.Close();
            if (VehicleLoans == null)
            {
                return new List<VehicleLoanEntity>();
            }
            else
            {
                return VehicleLoans;
            }

        }




    }
}
