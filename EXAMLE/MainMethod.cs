
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
        //Creating object to CustomerPresentationLayer
        CustomerPresentationLayer p = new CustomerPresentationLayer();
        p.start();

        //Creating object to CreditcardPresentationLayer
        CreditcardPresentationLayer cr = new CreditcardPresentationLayer();
        cr.start();


        //Creating The Object
        TransactionMenu.start();

       

        Console.ReadKey();
    }



}