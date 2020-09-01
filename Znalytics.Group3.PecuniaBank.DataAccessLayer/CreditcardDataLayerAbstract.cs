using System;
using System.Collections.Generic;
using Znalytics.PecuniaBanking.CustomerModule.Entities;//amespace of customer module entities

//namespace of credit card data access layer
namespace Znalytics.Group3.PecuniaBank.DataAccessLayer
{
 /// <summary>
 /// Abstract Class that represents CreditcardDataLayer
 /// </summary>
    public abstract class CreditcardDataLayerAbstract
    {

        //abstract method for getting CreditCardDetails by CustomerId
          public abstract List<Customer> GetApplyCreditCard();
    }
}

