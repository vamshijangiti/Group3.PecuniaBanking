
using Znalytics.Group3.PecuniaBank.PresentationLayer;
using Znalytics.PecuniaBanking.CustomerDetailModule.PresentationLayer;
using Znalytics.PecuniaBanking.Creditcard.PresentationLayer;
using System;

/// <summary>
/// Main Class 
/// </summary>
public class MainMethod
{
    static void Main()
    {
        CustomerPresentationLayer p = new CustomerPresentationLayer();
        p.start();


        //Creating The Object
        TransactionMenu.start();

        

        CreditcardPresentationLayer cr = new CreditcardPresentationLayer();
        cr.start();

        PersonalVehicleLoanPresentationLayer pv = new PersonalVehicleLoanPresentationLayer();
        pv.start();

        Console.ReadKey();
    }



}