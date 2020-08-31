// BusinessLogicLayer created by sriram
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.BusinessLogicLayer;
using Znalytics.Group3.PecuniaBank.DataAccessLayer;
using Znalytics.Group3.PecuniaBank.AccountEntities;
using static Znalytics.Group3.PecuniaBank.AccountEntities.SavingsAccount;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{/// <summary>
 /// BusinessLogicLayer for Accounts
 /// </summary>



  /*  public class SavingsAccountBusinessLogic : ISavingsAccountBusinessLogic
    {
        SavingsAccountDataAccessLayer _savingsaccountDataAccessLayer;


        public SavingsAccountBusinessLogic()
        {
            _savingsaccountDataAccessLayer = new SavingsAccountDataAccessLayer();
        }

        public void AddSavingsAccount(SavingsAccount s)
        {
            try
            {
                if (s.AccountId != 0)
                {
                    _savingsaccountDataAccessLayer.AddSavingsAccount(s);
                }
            }
            catch (Exception e)
            {
                throw new AccountException("account no should not be null");//Exception raised if accountid is zero
            }
        }

        public void DeleteSavingsAccount(SavingsAccount s)
        {
           /* _savingsaccountDataAccessLayer.DeleteSavingsAccount(s);*/
        }
   

    
