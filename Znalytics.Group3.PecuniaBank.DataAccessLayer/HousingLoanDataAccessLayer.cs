using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using Znalytics.Group3.PecuniaBank.HousingLoanEntities;


namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DataAccessLayer for HousingLoan
    /// </summary>
   /* public interface IHousingLoanDataAccessLayer
    {
        void Add(HousingLoan n);
        void UpdateHousingLoan(HousingLoan u);
    }*/
    public class HousingLoanDataAccessLayer:IHousingLoanDataAccessLayer
    {
        //private fields
      
        private static List<HousingLoan> _housingLoans;

        //constructor
        static HousingLoanDataAccessLayer()
        {

                       _housingLoans = new List<HousingLoan>();
            _housingLoans = LoadDetailsToList();
 {
                /*new HousingLoan() {CustomerId=1,CustomerAge=25,Tenure=3,LoanAmount=21000,CreditScore=456 };
                new HousingLoan() {CustomerId=2,CustomerAge=24,Tenure=1,LoanAmount=24000,CreditScore=660};
                new HousingLoan() { CustomerId = 3, CustomerAge = 20, Tenure = 2, LoanAmount = 20000, CreditScore = 690 };*/

            };
        }
           

        //Add HousingLoan
        public void Add(HousingLoan n)
        {
            HousingLoan cus = _housingLoans.Find(temp => temp.CustomerId == n.CustomerId);
                if (cus != null)
            {
                _housingLoans.Add(n);
                ListOfHousingLoan();
            }

        }
        //convert data into Json
        //Write data
        public void ListOfHousingLoan()
        {
            string s = JsonConvert.SerializeObject(_housingLoans);
            StreamWriter streamWriter = new StreamWriter(@"C:\\Users\Administrator\Desktop\HousingLoan\HousingLoan.txt");
            streamWriter.Write(s);
                
         }
        //read data into File
       public  static List<HousingLoan> LoadDetailsToList()
        {
            StreamReader streamReader = new StreamReader(@"C:\\Users\Administrator\Desktop\HousingLoan\HousingLoan.txt");
            string s1 = streamReader.ReadToEnd();
            List<HousingLoan> _housingLoans = JsonConvert.DeserializeObject < List<HousingLoan>>(s1);
            streamReader.Close();
            if (_housingLoans==null)
            {
                return new List<HousingLoan>();

            }
            else
            {
                return _housingLoans;
            }




        }
        //GetCustomerId
        public List<HousingLoan> GetCustomerId()
        {
            return _housingLoans;
        }

        public void RejectHousingLoan(HousingLoan housingLoan)
        {
            throw new NotImplementedException();
        }

        //UpdateCustomerIds
        public void RejectHousingLoan(HousingLoan u, int CreditScore)
        {
            HousingLoan cust = _housingLoans.Find(temp => temp.CreditScore == u.CreditScore);
            if (CreditScore<=650)
            {
                cust.CreditScore =u.CreditScore;
          
            }
        }
    }
}