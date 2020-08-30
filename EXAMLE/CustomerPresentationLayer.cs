using System;
using System.Collections.Generic;
using Znalytics.Group3.PecuniaBanking.BusinessLogicLayer;
using Znalytics.PecuniaBanking.CustomerModule.Entities;

namespace Znalytics.PecuniaBanking.CustomerDetailModule.PresentationLayer
{
    /// <summary>
    /// Represents Login information of the customer
    /// </summary>
    class CustomerPresentationLayer
    {
        
        public void start()
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


        /// <summary>
        ///  Method to add Customer Details
        /// </summary>
        static void AddCustomer()
        {
            try
            {

                //Creating object for Entity layer that is CustomerDetail class 
                Customer customer = new Customer();

                //Creating object for BusinessLogic Layer
                CustomerBusinessLogicLayer cb = new CustomerBusinessLogicLayer();

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
                customer.AnnualIncome = double.Parse(Console.ReadLine());

                //Reading customer's Pancard number manually
                Console.Write("Enter customer pancardnumber: ");
                customer.PanCardNumber = Console.ReadLine();

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
        /// <summary>
        /// Method to View existing Customer details
        /// </summary>
        static void GetCustomers()
        {
            //Creating object for CustomerPersonalDetail class 
            Customer customer = new Customer();

            //Creating object for BusinessLogic Layer
            CustomerBusinessLogicLayer cb = new CustomerBusinessLogicLayer();

            // CustomerDetailBLL customerBusinessLogic = new CustomerDetailBLL();
            //creating list
            List<Customer> cust = cb.GetCustomers();
            //getting customerdetails 
            foreach (Customer detail in cust)
            {
                Console.WriteLine(detail);

            }
        }

        /// <summary>
        /// Method to Update customer details
        /// </summary>
        static void UpdateCustomer()
        {

            //Creating object for CustomerPersonalDetail class 
            Customer customer = new Customer();

            //Creating object for BusinessLogic Layer
            CustomerBusinessLogicLayer cb = new CustomerBusinessLogicLayer();

            Console.Write("Enter Existing customer ID: ");/// updating name and other details by using primary key as customerid///
            customer.CustomerId = int.Parse(Console.ReadLine());
            Console.Write("enter customer name");
            customer.CustomerName = Console.ReadLine();
            cb.UpdateCustomer(customer);//Calss BusinessLogic Layer
            Console.WriteLine("Customer details Updated successfully");
        }

        

    }

}



