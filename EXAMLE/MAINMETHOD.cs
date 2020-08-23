
using Znalytics.Group3.PecuniaBank.PresentationLayer;
using System;

/// <summary>
/// Main Class 
/// </summary>
public class MainMethod
{
    static void Main()
    {
        //Creating The Object
        TransactionMenu t = new TransactionMenu();
        t.start();

        Console.ReadKey();
    }



}