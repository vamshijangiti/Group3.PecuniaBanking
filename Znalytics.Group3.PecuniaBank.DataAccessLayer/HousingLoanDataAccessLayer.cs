using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
 /// <summary>
 /// DataAccessLayer for HousingLoan
 /// </summary>
    class HousingLoan
    {
        List<long> accountNumbers = new List<long>() {123456789012,135792468012,102938475610,112233445566,223344556677,334455667788};
        List<string> AccountHoldersNames= new List<string>() { "sriram","vamshi","navya","sumanth","manasa","swetha"};
        ///<summary>
        ///Adding AccountNumbers into the list
        ///Addng AccountHolderNames into the list
        ///</summary>
        //<param name='n'>accountNumbers</param>
        //<param name='a'>AccountHolderNmaes</param>

        public void AddAccountNumbers(long n)
        {
           
            accountNumbers.Add(n);
            
        }
        public void AddAccountHolderNames(string a)
        {
            AccountHoldersNames.Add(a);

        }

    }
}
