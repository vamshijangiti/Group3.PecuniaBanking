//NAVYA personalloandataaccesslayer
using Newtonsoft.Json;
using System;
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
    /// Data access layer for Personalloan
    /// </summary>
    public class PersonalLoanDataAccessLayer
    {

        private static List<PersonalLoanEntity> _personalLoans;
        static PersonalLoanDataAccessLayer()
        {
            _personalLoans = new List<PersonalLoanEntity>();
            _personalLoans = LoadDetailsToList();
        }



        public void AddPersonalLoan(PersonalLoanEntity p)
        {
            _personalLoans.Add(p);
            ListOfPersonalLoanEntity();
        }
       public void ListOfPersonalLoanEntity()
        {
            string s = JsonConvert.SerializeObject(_personalLoans);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\PersonalLoan\Personal.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        public static List<PersonalLoanEntity> LoadDetailsToList()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\PersonalLoan\Personal.txt");
            string s2 = streamReader.ReadToEnd();
            List<PersonalLoanEntity> PersonalLoans = JsonConvert.DeserializeObject<List<PersonalLoanEntity>>(s2);
            streamReader.Close();
            if (PersonalLoans == null)
            {
                return new List<PersonalLoanEntity>();
            }
            else
            {
                return PersonalLoans;
            }

        }




    }
}
