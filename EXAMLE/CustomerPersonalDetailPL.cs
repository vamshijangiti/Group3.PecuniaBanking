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
             CustomerPersonalDetailBLL customerBusinessLogic = new CustomerPersonalDetailBLL();
             List<CustomerPersonalDetail> cust = customerBusinessLogic.GetCustomer();

             foreach (CustomerPersonalDetail emp in cust)
             {
                 Console.WriteLine(emp.EmployeeID + ", " + emp.EmployeeName);
             }
         }

         static void UpdateEmployee()
         {
             EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
             Employee employee = new Employee();

             Console.Write("Enter Existing Emp ID: ");
             employee.EmployeeID = int.Parse(Console.ReadLine());
             Console.Write("Enter New Emp Name: ");
             employee.EmployeeName = Console.ReadLine();

             employeeBusinessLogic.UpdateEmployee(employee);
             Console.WriteLine("Employee Updated.\n");
         }*/
        

    }
}

