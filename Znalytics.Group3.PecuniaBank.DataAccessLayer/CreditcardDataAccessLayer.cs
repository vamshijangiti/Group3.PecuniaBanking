﻿///// Manasa Data Access Layer/////

using System.Collections.Generic;
using Znalytics.PecuniaBanking.CreditcardModule.Entities;
using Znalytics.PecuniaBanking.CustomerModule.Entities;//namespace of customer module entities
using System.IO;
using Newtonsoft.Json;//namspace of json
using Znalytics.Group3.PecuniaBank.DataAccessLayer;//namespace of data access layer

namespace Znalytics.PecuniaBanking.CreditcardModule.DataAccessLayer
{
    /// <summary>
    /// Class that represents data access layer of creditcard which is child to the parent class of CreditCardDataLayerAbstract
    /// </summary>
    public class CreditcardDataAccessLayer: CreditcardDataLayerAbstract
    {
        
        //declaration of list of customers
        private static List<Customer> _customers;

        static CreditcardDataAccessLayer()
        {
            _customers = new List<Customer>()//Initialization of list of customers
            {

            };
        }

        /// <summary>
        /// Method For Saving FileInformation
        /// </summary>

        public void SaveIntoFile()
        {

            string a = JsonConvert.SerializeObject(_customers);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop");//Path of the text file
            streamWriter.Write(a);
            streamWriter.Close();
        }
        /// <summary>
        /// Method For Getting Data From File
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop");//path of the text file
            string a1 = streamReader.ReadToEnd();
            List<Customer> cust = JsonConvert.DeserializeObject<List<Customer>>(a1);
            return cust;

        }

        /// <summary>
        /// Method to add CreditCard details
        /// </summary>
        /// <param name="creditcard"></param>
        public void ApplyCreditCard(Customer creditcard)
        {
            _customers.Add(creditcard);//Adds customer details for applying creditcard to the presentation layer
            SaveIntoFile();
        }

        /// <summary>
        ///Method to get Credit card details
        /// </summary>
        /// <returns></returns>
        public override List<Customer> GetApplyCreditCard()
        {
            GetFiledata();
            return _customers;
            

        }


    }

}
