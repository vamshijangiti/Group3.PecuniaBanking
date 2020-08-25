using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.BusinessLogicLayer;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities;

namespace Znalytics.PecuniaBanking.CustomerPersonalDetailModule.PresentationLayer
{
    class Menu
    {
        static void Main()
        {
            CustomerDetailsPresentation();
            Console.ReadKey();
        }

        static void CustomerDetailsPresentation()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Customer Personal Details");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. View Customer");
                Console.WriteLine("3. Update Customer");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddCustomer(); break;
                    case 2: ViewCustomer(); break;
                    case 3: UpdateCustomer(); break;
                }
            } while (choice != 4);
        }


        public static void AddCustomer()
         {

            CustomerPersonalDetail customers = new CustomerPersonalDetail();

             Console.Write("Enter customer name: ");
             customers.CustomerId = Console.ReadLine();


             Console.Write("Enter customer Id: ");
             customers.CustomerId = Console.ReadLine();


            Console.Write("Enter Occupation: ");
            customers.Occupation = Console.ReadLine();

            Console.Write("Enter customer Address: ");
            customers.Address = Console.ReadLine();

            Console.Write("Enter customer Income: ");
            customers.Income =double.Parse( Console.ReadLine());

            Console.Write("Enter customer pancardnumber: ");
            customers.PanCardNumber = Console.ReadLine();

            Console.Write("Enter customer Aadharcardnumber: ");
            customers.AadharCardNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter customer Phone number: ");
            customers.PhoneNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter customer Date of Birth: ");
            customers.DateOfBirth= DateTime.Parse(Console.ReadLine());

            Console.Write("Enter customer MailId: ");
            customers.MailId = Console.ReadLine();

            ICustomerPersonalDetailBLL customerPersonaldetailBusinessLogicLayer = new ICustomerPersonalDetailBLL();
            customerPersonaldetailBusinessLogicLayer.AddCustomer(customers); //call BL

             Console.WriteLine("Customer details added successfully.\n");
         }

         static void ViewCustomer()
         {
             ICustomerPersonalDetailBLL customerBusinessLogic = new ICustomerPersonalDetailBLL();
             List<CustomerPersonalDetail> cust = customerBusinessLogic.GetCustomer();

             foreach (CustomerPersonalDetail detail in cust)
             {
                 Console.WriteLine(detail.CustomerId + ", " + detail.CustomerName);
             }
         }

         static void UpdateCustomer()
         {
             ICustomerPersonalDetailBLL CustomerBusinessLogic = new ICustomerPersonalDetailBLL();
             CustomerPersonalDetail customers = new CustomerPersonalDetail();

             Console.Write("Enter Existing Customer Name: ");
             customers.CustomerName = Console.ReadLine();
             Console.Write("Enter New Customer Name: ");
             customers.CustomerName = Console.ReadLine();

             Console.Write("Enter Existing Customer Address: ");
             customers.Address = Console.ReadLine();
             Console.Write("Enter New Customer Address: ");
             customers.Address = Console.ReadLine();

             Console.Write("Enter Existing Customer Income: ");
             customers.Income = double.Parse(Console.ReadLine());
             Console.Write("Enter New Customer Income: ");
             customers.Income = double.Parse(Console.ReadLine());

            Console.Write("Enter Existing Customer Aadharcardnumber: ");
            customers.AadharCardNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter New Customer Aadharcardnumber: ");
            customers.AadharCardNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter Existing Customer PancardNumber: ");
            customers.PanCardNumber = Console.ReadLine();
            Console.Write("Enter New Customer Pan card number: ");
            customers.PanCardNumber = Console.ReadLine();

            Console.Write("Enter Existing Customer Phone number: ");
            customers.PhoneNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter New Customer Phone number: ");
            customers.PhoneNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter Existing Customer date of birth: ");
            customers.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter New Customer date of birth: ");
            customers.DateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Existing Customer Mail Id: ");
            customers.MailId = Console.ReadLine();
            Console.Write("Enter New Customer mail id: ");
            customers.MailId = Console.ReadLine();


            CustomerBusinessLogic.UpdateCustomer(customers);
             Console.WriteLine("Customer details Updated.\n");
         }
        

    }
}

