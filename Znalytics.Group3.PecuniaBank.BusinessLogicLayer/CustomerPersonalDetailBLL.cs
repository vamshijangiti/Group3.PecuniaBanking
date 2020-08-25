using System;
using System.Text.RegularExpressions;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities;
using Znalytics.PecuniaBanking.DataAccessLayer;

namespace Znalytics.PecuniaBanking.BusinessLogicLayer
{
    public class CustomerPersonalDetailBLL : ICustomerPersonalDetailBLL
    {
        private ICustomerPersonalDetailDAL cdal = null;

        public CustomerPersonalDetailBLL()
        {
            cdal = new CustomerPersonalDetailDAL();
        }

        public void AddCustomer(CustomerPersonalDetail customers)
        {
            if (customers.CustomerName != null)
            {
                cdal.AddCustomer(customers);
            }
            else
            {
                throw new Exception("Please Mention your name");
            }

            //
            string checkPanCardNumber = @"^[A-Za-z]{5}[0-9]{4}[A-Za-z]{1}$";
            bool isPanCardNumberValid = Regex.IsMatch(txtPanCardNumber.Text.ToString().Trim(), checkPanCardNumber);
            if(isPanCardNumberValid==true)
            {
                cdal.AddCustomer(customers);
            }
            else
            {
                throw new Exception("Invalid Pancardnumber");
            }
            //

            

        }
    }
}
