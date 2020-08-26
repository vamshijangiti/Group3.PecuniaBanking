using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.PecuniaBanking.CreditcardModule.DataAccessLayer;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities;
using Znalytics.PecuniaBanking.DataAccessLayer;

namespace Znalytics.PecuniaBanking.BusinessLogicLayer
{
    public class CustomerPersonalDetailBLL : ICustomerPersonalDetailBLL
    {
        CustomerPersonalDetailDAL= cdal;

        public CustomerPersonalDetailBLL()
        {
            cdal = new CustomerPersonalDetailDAL();
        }


        public void AddCustomer(CustomerPersonalDetail customer)
        {

            if (customer.CustomerName != null)
            {
                cdal.AddCustomer(customer);
            }
            else
            {
                throw new Exception("Name can't be null,Please Mention your name");
            }

            //
            string checkPanCardNumber = @"^[A-Za-z]{5}[0-9]{4}[A-Za-z]{1}$";
            bool isPanCardNumberValid = Regex.IsMatch(txtPanCardNumber.Text.ToString().Trim(), checkPanCardNumber);
            if (isPanCardNumberValid == true)
            {
                cdal.AddCustomer(customer);
            }
            else
            {
                throw new Exception("Invalid Pancardnumber");
            }
            //

            if (customer.AadharCardNumber != null)
            {
                cdal.AddCustomer(customer);

            }
            else
            {
                throw new Exception("Please enter 12digit aadharcard number");
            }

            if (customer.PhoneNumber != null)
            {
                cdal.AddCustomer(customer);
            }
            else
            {
                throw new Exception("Phone number can't be null,Please enter 10digit Phonenumber");
            }

            if (customer.Age >= 18)
            {
                cdal.AddCustomer(customer);
            }
            else
            {
                throw new Exception("Age must be 18 and above");
            }
            void ValidateMailId()
            {

            }
        }
        public void  ValidateMailId(CustomerPersonalDetail customer)
        {

            string mail = customer.MailId;
            //searching for space
            bool spaceFound = mail.Contains(" ");

            //searching for @
            bool AtFound = mail.Contains("@");

            char[] ch = mail.ToCharArray();
            int AtCharCount = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '@')
                {
                    AtCharCount++;
                }
            }
            cdal.AddCustomer(customer);


        }
        public void ViewCustomer(CustomerPersonalDetail customer)
        {
             List<CustomerPersonalDetail> GetCustomers()
            {
                return _customerPersonalDetailDLL.GetCustomers();
            }
        }



            
            

            
        }
    }





}
    }
}
a