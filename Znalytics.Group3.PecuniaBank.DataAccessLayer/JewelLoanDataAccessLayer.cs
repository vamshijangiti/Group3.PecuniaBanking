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
    public class JewelLoanDataAccessLayer
    {
        //private fields
        private static List<GoldLoanCustomer> goldLoanCustomers;

        //constructor
        static JewelLoanDataAccessLayer()
        {
            _goldLoanCustomers = new List<GoldLoanCustomer>()
            {
                new GoldLoanCustomer(){ GoldLoanCustomerAccountNo =142357689012, GoldLoanCustomerName = "vamshi" },
                new GoldLoanCustomer(){ GoldLoanCustomerAccountNo=313242425577,GoldLoanCustomerName = "sumanth" }
            };
        }

        //Add
        public void Add(GoldLoanCustomer goldLoanCustomer)
        {
            _goldLoanCustomers.Add(goldLoanCustomer);
        }

        //Get all goldLoanCustomers
        public List<GoldLoanCustomer> GetGoldloanCustomers()
        {
            return _goldLoanCustomers;
        }

        //Update
        public void UpdateEmployee(GoldLoanCustomer goldLoanCustomer)
        {
            //Get matching GoldLoanCustomer based on GoldloanCustomerName
            GoldLoanCustomer gg = _goldLoanCustomers.Find(temp => temp.GoldLoanCustomerAccountNo == goldloanCustomer.GoldLoanCustomerAccountNo);
            if (gg != null)
            {
                gg.GoldLoanCustomerName = goldLoanCustomer.GoldLoanCustomerName;
            }
        }
    }
}
