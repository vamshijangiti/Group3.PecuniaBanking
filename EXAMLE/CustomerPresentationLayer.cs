//******************************Done by Manasa**************************//////


using System;
using System.Collections.Generic;
using Znalytics.Group3.PecuniaBanking.BusinessLayer;//Namespace ofCustomer BusinessLogic Layer
using Znalytics.PecuniaBanking.CustomerModule.Entities;//Name space of Customer Entities

//Namespace of Costumer PresentationLayer
namespace Znalytics.PecuniaBanking.CustomerModule.PresentationLayer
{
    /// <summary>
    /// class that represents Customer Presentation layer
    /// </summary>
    class CustomerPresentationLayer
    {
        //starting point of the execution
        public void start()
        {
            CustomersPresentation();
            Console.ReadKey();
        }

        //Displaying Customers menu
        static void CustomersPresentation()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("WELCOME TO PECUNIA BANK");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Get Customers");
                Console.WriteLine("3. Update Customer");
                Console.WriteLine("4. Get Customers by Customer Id");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());



                switch (choice)
                {
                    case 1: AddCustomer(); break;
                    case 2: GetCustomers(); break;
                    case 3: UpdateCustomer(); break;
                    case 4: GetCustomersByCustomerId(); break;
                    case 5: Console.WriteLine("Exit"); break;
                }
            } while (choice != 5);
        }


        /// <summary>
        /// Static Method to add Customer Details
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
                //Console.Write("Enter customer Id: ");
                //customer.CustomerId = int.Parse(Console.ReadLine());

                //Reading Occupation of customer manually
                Console.Write("Enter Profession: ");
                customer.Profession = Console.ReadLine();

                //Reading Address of custometr manually
                Console.Write("Enter customer Address: ");
                customer.Address = Console.ReadLine();

                //Reading Customer Income manually
                Console.Write("Enter customer Income: ");
                customer.AnnualIncome = double.Parse(Console.ReadLine());

                //Reading customer's Pancard number manually
                Console.Write("Enter customer Pancardnumber(Pancardnumber should starts with 5alphabets followed by 4digits and then 1alphabet(eg:asdfg1234g)): ");
                customer.PanCardNumber = Console.ReadLine();

                //Reading Customer's aadharcardnumber manually
                Console.Write("Enter customer Aadharcardnumber that must be 12 digits: ");
                customer.AadharCardNumber = Console.ReadLine();

                //Reading Phone number of customer manually
                Console.Write("Enter customer Phone number that must be 10 digits: ");
                customer.PhoneNumber = Console.ReadLine();

                //Reading Customer's age manually
                Console.Write("Enter Age ");
                customer.Age = int.Parse(Console.ReadLine());

                //Reading customer's mail id manually
                Console.Write("Enter customer MailId(eg:abc@gmail.com): ");
                customer.MailId = Console.ReadLine();

                cb.AddCustomer(customer); //calling the AddCustomer  method present in businessLogicLayer by using Reference variable
                Console.WriteLine("Customer details are added successfully");
            }
            catch(CustomerException ex)
            {
                throw new CustomerException(ex.Message);
            }
        }
        /// <summary>
        /// Method to View existing Customer details
        /// </summary>

        static void GetCustomers()
        {
            CustomerBusinessLogicLayer cbl = new CustomerBusinessLogicLayer();
            List<Customer> customers = cbl.GetCustomers();//getting all the customers stored in list

            Console.WriteLine("===============   customer Details=============");
            Console.WriteLine("CustomerID" + "   " + "CustomerName" + "  " + "MailId" + "  " + "Phonenumber" + " " + "address" + "  " + "AnnualIncome" + "  " + "aadharcardnumber" + "  " + "Pancardnumber");
            Console.WriteLine("-----------------------------------------------------------------------");

            foreach (Customer item in customers)//retrieves the data
            {
                Console.WriteLine(item.CustomerId + " " + item.CustomerName + " " + item.MailId + " " + item.AadharCardNumber + " " + item.Address + " " + item.AnnualIncome + " " + item.PanCardNumber + " " + item.Age + " " + item.Address + " " + item.AnnualIncome + " " + item.PanCardNumber + " " + item.Profession + " " + item.Address);// Displaying the products
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

            Console.Write("Enter Existing customer ID: ");/// updating name and other details by using  customerid///
            customer.CustomerId = int.Parse(Console.ReadLine());
            Console.Write("enter customer name: ");
            customer.CustomerName = Console.ReadLine();
            cb.UpdateCustomer(customer);//Calls BusinessLogic Layer
            Console.WriteLine("Customer details Updated successfully");
        }

        /// <summary>
        /// Method to get details by customer Id
        /// </summary>
        static void GetCustomersByCustomerId()
        {

            System.Console.Write("Enter the customerID: ");
            int CustomerId = int.Parse(System.Console.ReadLine());
            CustomerBusinessLogicLayer cbl = new CustomerBusinessLogicLayer(); //Creating object to BusinessLogic layer of customer
            Customer b = cbl.GetCustomersByCustomerId(CustomerId);///which calls the businesslogic of GetCustomersByCustomerId method///
            System.Console.WriteLine(b.CustomerId + " " + b.CustomerName + " " + b.Address + " " + b.PanCardNumber + " " + b.AadharCardNumber + " " + b.Profession + " " + b.PhoneNumber + " " + b.AnnualIncome);


        }



    }

}



