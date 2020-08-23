using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.Entities;

namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
    /// <summary>
    /// DataAccessLayer for Jewel Loan
    /// </summary>
    public class JewelLoanDataAccessLayer
    {
        //private fields
        private static List<GoldLoan> _goldLoans;

        //constructor
        static JewelLoanDataAccessLayer()
        {
            _goldLoans = new List<GoldLoan>()
            {
                new GoldLoan() { CustId = 1, CarotType = 22, Age = 20, tenure = 1.2 },
                new GoldLoan() { CustId = 2, CarotType = 24, Age = 23, tenure = 1 },
            };
        }

        //Add
        public void Add(GoldLoan custId)
        {
            _goldLoans.Add(custId);
        }
    }
}

       