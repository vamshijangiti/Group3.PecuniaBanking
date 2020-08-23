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
        private static List<JewelLoan> _JewelLoans;

        //constructor
        static JewelLoanDataAccessLayer()
        {
            _JewelLoans = new List<JewelLoan>();
            {
                new JewelLoan() { CustId = 1, CarotType = 22, Age = 20, tenure = 1.2 };
                new JewelLoan() { CustId = 2, CarotType = 24, Age = 23, tenure=1 };
        };
    }

  

        //Add

        public void Add(JewelLoan custId)
        {
            _JewelLoans.Add(custId);
        }
        public List<JewelLoan> GetCustId()
        {
            return _JewelLoans;
        }
        //UpdateJewelLoan
        public void UpdateJewelLoan(JewelLoan custId)
        {
            JewelLoan cust = _JewelLoans.Find(temp => temp.CustId == custId.CustId);
            if (cust != null)
            {
                cust.CustId = cust.CustId;
            }
        }

    }
}

       