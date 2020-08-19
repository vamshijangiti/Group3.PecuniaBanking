using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DataAccessLayer for Jewel Loan
    /// </summary>
    class JewelLoan
    {
        List<long>AccountNumbers=new List<long>() { 231313334567,334444444467,4444455556666,676767121212};
        List<int> AgeOfCustomer = new List<int> { 21, 45, 32, 41 };
        ///<summary>
        ///Adding AccountNos in the list
        /// </summary>
        ///<param name='t'>AccountNumbers</param>
        ///<param name="='c'>AgeOfCustomer</param>
        public void AddAccountNumbers(long t)
        {
            AccountNumbers.Add(t);
        }
        public void AddAgeOfCustomer(int c)
        {
            AgeOfCustomer.Add(c);
        }
    }
}
