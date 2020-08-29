using System;
using System.Collections.Generic;
using Znalytics.Group3.PecuniaBanking.BusinessLogicLayer;
using Znalytics.PecuniaBanking.CustomerDetailModule.Entities;

namespace Znalytics.PecuniaBanking.CustomerDetailModule.PresentationLayer
{
    /// <summary>
    /// Represents Login information of the customer
    /// </summary>
    class CustomerDetailPL
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
                Console.WriteLine("2. Get Customers");
                Console.WriteLine("3. Update Customer");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddCustomer(); break;
                    case 2: GetCustomers(); break;
                    case 3: UpdateCustomer(); break;
                    case 4: Console.WriteLine("Exit");break;
                }
            } while (choice != 4);
        }


        //Add customer method
        static void AddCustomer()
        {
            try
            {

                //Creating object for CustomerPersonalDetail class 
                CustomerDetail customer = new CustomerDetail();

                //Creating object for BusinessLogic Layer
                CustomerDetailBLL cb = new CustomerDetailBLL();

                //Reading customer name manually
                Console.Write("Enter customer name: ");
                customer.CustomerName = Console.ReadLine();

                //Reading customer Id manually
                Console.Write("Enter customer Id: ");
                customer.CustomerId = int.Parse(Console.ReadLine());

                //Reading Occupation of customer manually
                Console.Write("Enter Occupation: ");
                customer.Profession = Console.ReadLine();

                //Reading Address of custometr manually
                Console.Write("Enter customer Address: ");
                customer.Address = Console.ReadLine();

                //Reading Customer Income manually
                Console.Write("Enter customer Income: ");
                customer.Income = double.Parse(Console.ReadLine());

                //Reading customer's Pancard number manually
                Console.Write("Enter customer pancardnumber: ");
                customer.PanCardNumber = long.(Console.ReadLine();

                //Reading Customer's aadharcardnumber manually
                Console.Write("Enter customer Aadharcardnumber: ");
                customer.AadharCardNumber = Console.ReadLine();

                //Reading Phone number of customer manually
                Console.Write("Enter customer Phone number: ");
                customer.PhoneNumber = Console.ReadLine();

                //Reading Customer's age manually
                Console.Write("Enter customer Age: ");
                customer.DateOfBirth = DateTime.Parse(Console.ReadLine());

                //Reading customer's mail id manually
                Console.Write("Enter customer MailId: ");
                customer.MailId = Console.ReadLine();


                // CustomerDetailBLL customerPersonaldetailBusinessLogicLayer = new CustomerDetailBLL();
                cb.AddCustomer(customer); //call BusinessLogicLayer

                Console.WriteLine("Customer details added successfully.\n");
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                //Console.WriteLine();
                //Console.WriteLine(ex.StackTrace);
                //Console.WriteLine();
                // Console.WriteLine(ex.Source);
            }

        }
        //View existing Customer details
        static void GetCustomers()
        {
            //Creating object for CustomerPersonalDetail class 
            CustomerDetail customer = new CustomerDetail();

            //Creating object for BusinessLogic Layer
            CustomerDetailBLL cb = new CustomerDetailBLL();

            // CustomerDetailBLL customerBusinessLogic = new CustomerDetailBLL();
            //creating list
            List<CustomerDetail> cust = cb.GetCustomers();
            //getting customerdetails 
            foreach (CustomerDetail detail in cust)
            {
                Console.WriteLine(detail);

            }
        }

        //Updating customer details
        static void UpdateCustomer()
        {

            //Creating object for CustomerPersonalDetail class 
            CustomerDetail customer = new CustomerDetail();

            //Creating object for BusinessLogic Layer
            CustomerDetailBLL cb = new CustomerDetailBLL();


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
            customer.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter New Customer date of birth: ");
            customer.DateOfBirth = DateTime.Parse(Console.ReadLine());

            //Updating Mail id
            Console.Write("Enter Existing Customer Mail Id: ");
            customer.MailId = Console.ReadLine();
            Console.Write("Enter New Customer mail id: ");
            customer.MailId = Console.ReadLine();


            cb.UpdateCustomer(customer);
            Console.WriteLine("Customer details Updated.\n");
        }

    }

}



