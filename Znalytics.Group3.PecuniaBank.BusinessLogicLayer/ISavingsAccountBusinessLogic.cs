﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group3.PecuniaBank.AccountEntities;

namespace Znalytics.Group3.PecuniaBank.BusinessLogicLayer
{
    interface  ISavingsAccountBusinessLogic
    {
        long GenerateAccountNumber(long AccountNumber);
        void AddSavingsAccount(SavingsAccount savingsAccount);
        void DeleteSavingsAccount(SavingsAccount savingsAccount);

        List<SavingsAccount> GetSavingsAccounts();
    }
}
