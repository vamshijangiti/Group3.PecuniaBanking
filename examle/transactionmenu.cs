
//CREATED BY VAMSHI JANGITI --- PRESENTATION LAYER




//using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.Entities;
namespace Znalytics.Group3.PecuniaBank.PresentationLayer
{
    /// <summary>
    /// Presentation Class For WithDrawl And Debit
    /// </summary>
    public class TransactionMenu
    {
        static long uan;
        static bool flag;
        public static void start()
        {
            //object Declaration for classes
            TransactionBusinessLogic b = new TransactionBusinessLogic();
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

                    Console.WriteLine("should not be null or Empty");
                    break;
                }
                else if (f == 2)
                {
                    //throw new Exception("\n Please Enter valid Account number : ");

                    Console.WriteLine("The Account Number Should Be  3 digits");
                }
                else if (f == 3)
                {
                    uan = long.Parse(suan);
                    flag = true;
                    break;
                }
                else if (f == 4)
                {
                    Console.WriteLine("doesnot not Contain Alphabates please enter Again\n");
                }

            }

            if (flag == true)
            {
                try
                {
                    //if User entered Account Number is Equals To  Account Number
                    if (b.GetAccountNumber(uan) == true)
                    {

                        System.Console.WriteLine("\n\t\t************* WELCOME TO PECUNIA BANK ***********\t\t \n\n");
                        char ch = 'Y';
                        do
                        {
                            //Menu For Choosing Options
                            System.Console.WriteLine("\nStart Your Transaction\n");
                            System.Console.WriteLine("\n1 - FOR DEPOSIT");
                            System.Console.WriteLine("\n2 - FOR WITHDRAWL");
                            System.Console.WriteLine("\n3 - CHECK BALANCE");
                            System.Console.WriteLine("\n4 - Transactions");
                            System.Console.WriteLine("\n5- EXIT");
                            Console.Write("\nEnter Your choice : ");
                            int n;
                            n = int.Parse(System.Console.ReadLine());



                            //Switch Case for Choosing the Options
                            switch (n)
                            {

                                case 1:
                                    DisplayDeposit();
                                    break;
                                case 2:

                                    DisplayWithDrawl();
                                    break;
                                case 3:
                                    checkBalance();
                                    break;
                                case 4:
                                    GetLastTransactions();
                                    break;
                                default:
                                    Console.WriteLine("Ooops......You have Choosen Wrong Option\n");
                                    break;

                            }
                            Console.Write("\n Do you want to Use it Again press Y else N : ");
                            ch = char.Parse(Console.ReadLine());

                        } while (ch == 'Y' || ch == 'y');
                    }
                    else
                    {
                        throw new Exception("\nAccount does not exist\nPlease enter a valid Account Number");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }





            void GetLastTransactions()//Getting the Last 10 Transactions
            {
                //creating list 
                List<Transaction> tc = b.GetTransactions(uan);

                if (tc != null)
                {
                    Console.WriteLine(" 1.Savings\n 2.Current\n");
                    int m = int.Parse(Console.ReadLine());
                    switch (m)
                    {
                        case 1:
                            if (b.TypeCheck("Savings", uan))
                            {
                                foreach (var item in tc)
                                    //  if (item != null)// && item.TransactionTpe == "Savings")
                                    //{
                                    Console.WriteLine("------ Transactions : " + item.TransactionID + " " + item.TransactionDate + " " + item.TransactionAmount + " " + item.TransactionTpe);
                                //}
                                //else
                                //{
                                //   Console.WriteLine("\nsorry No Transactions are done for last 10 days. ");
                                //}
                            }
                            else
                            {
                                Console.WriteLine("You Dont Have Current Account ");
                            }
                            break;
                        case 2:
                            if (b.TypeCheck("Current", uan))
                            {
                                foreach (var item in tc)
                                    if (item != null && item.TransactionTpe == "Current")
                                    {
                                        Console.WriteLine(" Transactions : " + item.TransactionID + " " + item.TransactionDate + " " + item.TransactionAmount + " " + item.TransactionTpe);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nsorry No Transactions are done for last 10 days. ");
                                    }
                            }
                            else
                            {
                                Console.WriteLine("You Dont Have Savings Account ");
                            }
                            break;
                        default:
                            Console.WriteLine("Ooops......You Choosen Wrong Option\n");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine(" No  ");
                }
            }


            void checkBalance()//Cheking the Balance
            {
                Console.WriteLine(" Avaiable Balance : " + b.GetAmount(uan));
            }



            static void DisplayDeposit() //For Displaying the Deposited Amount
            {
                Transaction e1 = new Transaction();

                e1.AccountNumber = uan;
                Console.WriteLine("\nSelect type of Account \n 1.Savings \n 2.Current\n");
                string n = Console.ReadLine();
                TransactionBusinessLogic b = new TransactionBusinessLogic();

                try
                {

                    switch (n)
                    {
                        case "1":
                            if (b.TypeCheck("Savings", uan))
                            {
                                e1.TransactionTpe = "Savings";
                                Console.WriteLine("\nEnter amount to Deposit ");
                                e1.TransactionAmount = double.Parse(Console.ReadLine());
                                if (b.SavingsTransactionValidation(e1.TransactionTpe, e1.TransactionAmount) == true)
                                {
                                    e1.TransactionDate = System.DateTime.Today;

                                    b.AddTranscation(e1);
                                    b.Deposit(e1.AccountNumber, e1.TransactionAmount);
                                    if (b.ValidateEnteredAmount(e1.TransactionAmount) == true)
                                    {
                                        Console.WriteLine("\nThe Deposited Amount is : " + e1.TransactionAmount);

                                    }
                                    else
                                    {
                                        Console.WriteLine("\nAmount should be Greater than 500 \n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("For Savings the Deposit Amount should not Exceed 1 Lakh ");

                                }
                            }
                            else
                            {
                                Console.WriteLine("\nYou Don't have Savings Account ");

                            }


                            break;

                        case "2":
                            if (b.TypeCheck("Current", uan))
                            {
                                e1.TransactionTpe = "Current";
                                Console.WriteLine("\nEnter amount to Deposit ");
                                e1.TransactionDate = System.DateTime.Today;
                                e1.TransactionAmount = double.Parse(Console.ReadLine());
                                b.AddTranscation(e1);
                                b.Deposit(e1.AccountNumber, e1.TransactionAmount);
                                if (b.CurrentTransactionValidation(e1.TransactionTpe, e1.TransactionAmount) == true)
                                {
                                    if (b.ValidateEnteredAmount(e1.TransactionAmount) == true)
                                    {
                                        Console.WriteLine("\nThe Deposited Amount is : " + e1.TransactionAmount);

                                    }
                                    else
                                    {
                                        Console.WriteLine("\nAmount should be Greater than 500 \n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("For Current Account the Deposit Amount Can be 5 lakh but not exceeded");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You Dont have Current Account");
                            }
                            break;
                        default:
                            Console.WriteLine("Ooops......You have Choosen Wrong Option\n");

                            break;
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Enter Correct Data");

                }



            }


            static void DisplayWithDrawl() //For Displaying the WithDrawled Amount
            {

                //creating the object
                Transaction e1 = new Transaction();
                TransactionBusinessLogic b = new TransactionBusinessLogic();
                Console.WriteLine("\nSelect the type of Account");
                Console.WriteLine("\nSelect type of Account \n 1.Savings \n 2.Current\n");
                String n = Console.ReadLine();

                try
                {

                    switch (n)
                    {
                        case "1":
                            e1.TransactionTpe = "Savings";
                            Console.WriteLine("\nEnter amount to WithDrawl");
                            e1.TransactionAmount = double.Parse(Console.ReadLine());
                            e1.TransactionDate = System.DateTime.Today;
                            e1.AccountNumber = uan;
                            b.AddTranscation(e1);
                            if (b.ValidateEnteredAmount(e1.TransactionAmount) == true)
                            {
                                int f = b.WithDrawlAmount(e1.AccountNumber, e1.TransactionAmount);
                                if (f == 1)
                                {
                                    Console.WriteLine("\nThe WithDrawled Amount is : " + e1.TransactionAmount);
                                }
                                else if (f == 2)
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
                            break;
                        case "2":
                            e1.TransactionTpe = "Current";
                            Console.WriteLine("\nEnter amount to WithDrawl");
                            e1.TransactionAmount = double.Parse(Console.ReadLine());
                            e1.TransactionDate = System.DateTime.Today;
                            e1.AccountNumber = uan;
                            b.AddTranscation(e1);
                            if (b.ValidateEnteredAmount(e1.TransactionAmount) == true)
                            {
                                //   if (b.ValidateWithDrawl(e1.TransactionAmount) == true)

                                int f = b.WithDrawlAmount(e1.AccountNumber, e1.TransactionAmount);
                                if (f == 1)
                                {
                                    Console.WriteLine("\nThe WithDrawled Amount is : " + e1.TransactionAmount);
                                }
                                else if (f == 2)
                                {
                                    Console.WriteLine("\nAmount is Exceeded");

                                }
                                else
                                {
                                    Console.WriteLine("\nAccount Not Exists");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nThe Withdrawl Amount Should Be Greater Than 500\n");
                            }
                            break;
                        default:
                            Console.WriteLine("\nOoops......You Choosen Wrong Option\n");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Enter Correct Data");

                }



            }
        }
    }
}


