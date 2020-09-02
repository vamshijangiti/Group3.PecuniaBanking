
//CREATED BY VAMSHI JANGITI --- PRESENTATION LAYER

using System;
using System.Collections.Generic;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.Entities;
using Znalytics.Group3.PecuniaBank.Entities.TransactionException;
namespace Znalytics.Group3.PecuniaBank.PresentationLayer
{
    /// <summary>
    /// Presentation Class For WithDrawl And Debit
    /// </summary>
    public class TransactionMenu
    {
        static long uan;
        static bool flag;

        public static void Start()
        {
            //object Declaration for classes
            TransactionBusinessLogic b = new TransactionBusinessLogic();
            Transaction e1 = new Transaction();
            //Random Class
            Random random = new Random();

            while (true) //checking whether the entered Accout is correct or not
            {

                //Gives Random Numbers within 10 

                int num1 = random.Next(10);
                int num2 = random.Next(10);
                Console.Write("\nSecurity Check \n");
                Console.Write("\nPress Enter If you Want New Security Numbers \n");
                Console.Write("\nenter sum of " + num1 + "+" + num2 + " = "); //Reading the user entered Data
                bool t = int.TryParse(Console.ReadLine(), out int r); //Tryparse
                if (r != (num1 + num2) || string.IsNullOrEmpty((r.ToString())))
                    continue;
                Console.Write("\nEnter AccountNumber : ");
                string suan = Console.ReadLine();

                int f = b.ValidateAccountNumber(suan);

                if (f == 1)//Validating The Account Number 
                {

                    Console.WriteLine("\nAccount Number should not be Empty");
                }
                else if (f == 2)
                {
                    Console.WriteLine("\nThe Account Number Doesnot Contain Alphabates ");
                }
                else if (f == 3)
                {

                    uan = long.Parse(suan);
                    // e1.AccountNumber = uan;
                    flag = true;
                    break;
                }
                else if (f == 4)
                {
                    Console.WriteLine("\nThe Account Number Should Be  3 digits\n");
                }
                else if (f == 5)
                {
                    Console.WriteLine("\nThe Account Number Should Not Contain Spaces\n");
                }

            }

            if (flag == true)
            {
                try
                {
                    //if User entered Account Number is Equals To  Account Number
                    if (b.CheckAccountNumber(uan) == true)
                    {

                        System.Console.WriteLine("\n\t\t************* WELCOME TO PECUNIA BANK ***********\t\t \n\n");
                        string ch = "Y";
                        do
                        {
                            //Menu For Choosing Options
                            System.Console.WriteLine("\nStart Your Transaction\n");
                            System.Console.WriteLine("\n1 - FOR DEPOSIT");
                            System.Console.WriteLine("\n2 - FOR WITHDRAWL");
                            System.Console.WriteLine("\n3 - Last Transactions");
                            System.Console.WriteLine("\n4 - EXIT");
                            Console.Write("\nEnter Your choice : ");

                            string n = System.Console.ReadLine();



                            //Switch Case for Choosing the Options
                            switch (n)
                            {

                                case "1":
                                    DisplayDeposit();
                                    break;
                                case "2":
                                    DisplayWithDrawl();
                                    break;
                                case "3":
                                    GetLastTransactions();
                                    break;
                                case "4":
                                    break;
                                default:
                                    Console.WriteLine("\nOoops......You have Choosen Wrong Option\n");
                                    break;

                            }
                            Console.Write("\n Do you want do Transactions Again press Y else Press Any Key: ");
                            ch = Console.ReadLine();

                        } while (ch == "Y" || ch == "y");
                    }
                    else
                    {
                        //Custom Exception
                        throw new TransactionException("\n\nAccount does not exist");

                    }
                }
                catch (TransactionException e)
                {

                    Console.WriteLine(e.Message);

                }

            }




            //Getting the Last 10 Transactions
            void GetLastTransactions()
            {
                //creating list 
                List<Transaction> tc = b.GetTransactions(uan);

                if (tc != null && tc.Count > 0)
                {
                    foreach (var item in tc)
                        Console.WriteLine("\tTransactions : " + item.TransactionID + " " + item.TransactionDate + " " + item.TransactionAmount + " " + item.TransactionTpe);

                }

                else
                {
                    Console.WriteLine("\nNo Transactions are done Recently ");
                }
            }

            //For Displaying the Deposited Amount
            static void DisplayDeposit()
            {
                Transaction e1 = new Transaction();
                e1.AccountNumber = uan;

                TransactionBusinessLogic b = new TransactionBusinessLogic();

                try
                {

                    e1.TransactionTpe = "Deposit";
                    Console.WriteLine("\nEnter amount to Deposit ");
                    e1.TransactionAmount = double.Parse(Console.ReadLine());
                    if (b.DepositTransactionValidation(e1) == true)//Validating the Type of Account
                    {

                        if (b.ValidateEnteredAmount(e1.TransactionAmount) == true)//Validating the Entered Amount
                        {
                            e1.TransactionDate = System.DateTime.Today;//Assigning Today's date

                            b.DepositAmount(e1);//Validating the Amount
                            b.AddTranscation(e1);//Passing the object
                            Console.WriteLine("\nThe Deposited Amount is : " + e1.TransactionAmount);

                        }
                        else
                        {
                            Console.WriteLine("\nAmount should be Greater than 500 \n");//Entered Amount should be greater than 500
                        }
                    }
                    else
                    {
                        Console.WriteLine("For Deposit Amount should not Exceed 1 Lakh ");//Entered Amount should be less than 1 Lakh

                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Enter in Digits");
                }
            }

            //For Displaying the WithDrawled Amount
            static void DisplayWithDrawl()
            {

                //creating the object
                Transaction e1 = new Transaction();
                TransactionBusinessLogic b = new TransactionBusinessLogic();
                try
                {

                    e1.TransactionTpe = "WithDrawl";//This case Is for SavingsAccount Transaction
                    Console.WriteLine("\nEnter amount to WithDrawl");
                    e1.TransactionAmount = double.Parse(Console.ReadLine());//Reading Transaction Amount From Keyboard
                    e1.TransactionDate = DateTime.Today;
                    e1.AccountNumber = uan;//Assigning the Date 

                    if (b.ValidateEnteredAmount(e1.TransactionAmount) == true)//Validates The Whether the Amount is Greater than 500 or not
                    {
                        int f = b.WithDrawlAmount(e1);//calling the Method 
                        if (f == 1)//Returns when condition is successful
                        {
                            b.AddTranscation(e1);// Calling the Method
                            Console.WriteLine("\nThe WithDrawled Amount is : " + e1.TransactionAmount);
                        }
                        else if (f == 2)//If Entered amount is More Than Available balance 
                        {
                            Console.WriteLine("\nAmount is Exceeded");

                        }
                        else
                        {
                            Console.WriteLine("Account Not Exists");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The Withdrawl Amount Should Be Greater Than 500");
                    }

                }
                //Catches the Exception 
                catch (FormatException )
                {
                    Console.WriteLine("\n Please Enter in Digits\n");

                }
            }
        }
    }
}


