//PresentationLayer created by sriram


using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.Entities;
namespace Znalytics.Group3.PecuniaBank.PresentationLayer
{
    class Account
    {
        private int accountNo;

        public static void AccountsPresentationLayer()
        {
            int choice = 0;
            do
            {
                System.Console.WriteLine("WELCOME TO PECUNIA BANKING");
                System.Console.WriteLine("Menu");
                System.Console.WriteLine("1. Add Account ");
                System.Console.WriteLine("2. view Account");
                System.Console.WriteLine("3.UpdateAccount");
                System.Console.WriteLine("4.DeleteAccount");
                System.Console.WriteLine("5. Exit");
                System.Console.WriteLine("Enter the choice: ");
                choice = int.Parse(System.Console.ReadLine());
                switch (choice)
                {
                    case 1: AddAccount(); break;
                    case 2: ViewAccount(); break;
                    case 3: UpdateAccount(); break;
                    case 4: DeleteAccount(); break;


                }
            } while (choice != 5);


            static void AddAccount()
            {
               
            }
            static void ViewAccount()
            {
               
            }

        }

        static void UpdateAccount()
        {

        }

        static void DeleteAccount()
        {

        }
    }
}
