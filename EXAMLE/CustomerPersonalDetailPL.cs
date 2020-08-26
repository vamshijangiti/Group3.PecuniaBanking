using System;
using System.Collections.Generic;
using Znalytics.Group3.PecuniaBanking.BusinessLogicLayer;
using Znalytics.PecuniaBanking.CustomerPersonalDetailModule.Entities;

namespace Znalytics.PecuniaBanking.CustomerPersonalDetailModule.PresentationLayer
{
    /// <summary>
    /// Represents Login information of the customer
    /// </summary>
    class Menu
    {
        //Starting point of the Execution
        static void Main()
        {
            CustomerDetailsPresentation();
            Console.ReadKey();
        }

        //Displaying Customers menu
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

        //Add customer method
        public static void AddCustomer()
         {
            //Creating object for CustomerPersonalDetail class 
            CustomerPersonalDetail customers = new CustomerPersonalDetail();

            //Reading customer name manually
             Console.Write("Enter customer name: ");
             customers.CustomerId = Console.ReadLine();

            //Reading customer Id manually
             Console.Write("Enter customer Id: ");
             customers.CustomerId = Console.ReadLine();

            //Reading Occupation of customer manually
            Console.Write("Enter Occupation: ");
            customers.Occupation = Console.ReadLine();

            //Reading Address of custometr manually
            Console.Write("Enter customer Address: ");
            customers.Address = Console.ReadLine();

            //Reading Customer Income manually
            Console.Write("Enter customer Income: ");
            customers.Income =double.Parse( Console.ReadLine());

            //Reading customer's Pancard number manually
            Console.Write("Enter customer pancardnumber: ");
            customers.PanCardNumber = Console.ReadLine();

            //Reading Customer's aadharcardnumber manually
            Console.Write("Enter customer Aadharcardnumber: ");
            customers.AadharCardNumber = Console.ReadLine();

            //Reading Phone number of customer manually
            Console.Write("Enter customer Phone number: ");
            customers.PhoneNumber = Console.ReadLine();

            //Reading Customer's age manually
            Console.Write("Enter customer Age: ");
            customers.Age= int.Parse(Console.ReadLine());

            //Reading customer's mail id manually
            Console.Write("Enter customer MailId: ");
            customers.MailId = Console.ReadLine();

            CustomerPersonalDetailBLL customerPersonaldetailBusinessLogicLayer = new CustomerPersonalDetailBLL();
            customerPersonaldetailBusinessLogicLayer.AddCustomer(customers); //call BUsinessLogicLayer

             Console.WriteLine("Customer details added successfully.\n");
         }
        //View existing Customer details
         static void ViewCustomer()
         {
             CustomerPersonalDetailBLL customerBusinessLogic = new CustomerPersonalDetailBLL();
            //creating list
             List<CustomerPersonalDetail> cust = customerBusinessLogic.GetCustomer();

            //getting customerdetails 
             foreach (CustomerPersonalDetail detail in cust)
             {
                 Console.WriteLine(detail);
             }
         }

        //Updating customer details
         static void UpdateCustomer()
         {
            //Creating object for BusinessLogicLayer
             CustomerPersonalDetailBLL CustomerBusinessLogic = new CustomerPersonalDetailBLL();

            //Creating object for the CustomerPersonalDetail class
             CustomerPersonalDetail customer = new CustomerPersonalDetail();

            //Updating name
             Console.Write("Enter Existing Customer Name: ");
             customer.CustomerName = Console.ReadLine();
             Console.Write("Enter New Customer Name: ");
             customer.CustomerName = Console.ReadLine();

            //Updating Address
             Console.Write("Enter Existing Customer Address: ");
             customer.Address = Console.ReadLine();
             Console.Write("Enter New Customer Address: ");
             customer.Address = Console.ReadLine();

            //Updating Income
             Console.Write("Enter Existing Customer Income: ");
             customer.Income = double.Parse(Console.ReadLine());
             Console.Write("Enter New Customer Income: ");
             customer.Income = double.Parse(Console.ReadLine());

            //Updating AadharcardNumber
            Console.Write("Enter Existing Customer Aadharcardnumber: ");
            customer.AadharCardNumber = Console.ReadLine();
            Console.Write("Enter New Customer Aadharcardnumber: ");
            customer.AadharCardNumber = Console.ReadLine();

            //Updating PanCardNumber
            Console.Write("Enter Existing Customer PancardNumber: ");
            customer.PanCardNumber = Console.ReadLine();
            Console.Write("Enter New Customer Pan card number: ");
            customer.PanCardNumber = Console.ReadLine();

            //Updating Phone number
            Console.Write("Enter Existing Customer Phone number: ");
            customer.PhoneNumber = Console.ReadLine();
            Console.Write("Enter New Customer Phone number: ");
            customer.PhoneNumber = Console.ReadLine();

            //Updating Age
            Console.Write("Enter Existing Customer Age: ");
            customer.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter New Customer date of birth: ");
            customer.Age = int.Parse(Console.ReadLine());

            //Updating Mail id
            Console.Write("Enter Existing Customer Mail Id: ");
            customer.MailId = Console.ReadLine();
            Console.Write("Enter New Customer mail id: ");
            customer.MailId = Console.ReadLine();


            CustomerBusinessLogic.UpdateCustomer(customer);
             Console.WriteLine("Customer details Updated.\n");
         }
        

    }
}

