
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
        //Creating The Object
        TransactionMenu.start();

        CustomerPresentationLayer p = new CustomerPresentationLayer();
        p.start();

        CreditcardPresentationLayer cr = new CreditcardPresentationLayer();
        cr.start();

        Console.ReadKey();
    }



}