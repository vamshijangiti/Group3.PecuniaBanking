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
        void AddSavingsAccount(SavingsAccount s);
        void DeleteSavingsAccount(SavingsAccount s);
        public List<SavingsAccount>GetSavingsAccounts();

    }
}