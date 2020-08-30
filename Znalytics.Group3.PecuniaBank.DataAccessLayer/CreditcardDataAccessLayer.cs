///// Manasa Data Access Layer/////

using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;
using Znalytics.PecuniaBanking.CustomerModule.Entities;
using System.IO;
using Newtonsoft.Json;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;

namespace Znalytics.PecuniaBanking.CreditcardModule.DataAccessLayer
{
    /// <summary>
    /// Class that represents data access layer of creditcard
    /// </summary>
    public class CreditcardDataAccessLayer: CreditcardDataLayerAbstract
    {
        //create list

        private static List<Customer> _customers;

        static CreditcardDataAccessLayer()
        {
            _customers = new List<Customer>()
            {

            };
        }

        /// <summary>
        /// Method For Saving FileInformation
        /// </summary>

        public void SaveIntoFile()
        {

            string s = JsonConvert.SerializeObject(_customers);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\DesktopJson.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        /// <summary>
        /// Method For Getting Data From File
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\DesktopJson.txt");
            string s1 = streamReader.ReadToEnd();
            List<Customer> cust = JsonConvert.DeserializeObject<List<Customer>>(s1);
            return cust;

        }

        //Method to add CreditCards
        public void ApplyCreditCard(Customer creditcard)
        {
            _customers.Add(creditcard);
            SaveIntoFile();
        }

        public override List<Customer> GetApplyCreditCard()
        {
            GetFiledata();
            return _customers;

        }


    }

}
