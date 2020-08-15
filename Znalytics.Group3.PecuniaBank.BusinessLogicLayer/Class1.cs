using System;
/// <summary>
/// Represents Pecunia Banking
/// </summary>
public class Customer
{
    private int _ActNo;
    private float _Charges;
    private float _Credits;
    private float _CreditLimit;
    private float _creditScore;

    /// <summary>
    /// Set values into AccountNumber
    /// </summary>
    /// <param name="value"> Value assign into SetActNo</param>
    public void SetActNo(int value)
    {
        _ActNo = value;
    }
    public int GetActNo()
    {
        return _ActNo;
    }

    /// <summary>
    /// Set value into Charges
    /// </summary>
    /// <param name="value">Value assign into SetCharges</param>

    public void SetCharges(float value)
    {
        _Charges = value;
    }
    public float GetCharges()
    {
        return _Charges;
    }

    /// <summary>
    /// Set values into Credits
    /// </summary>
    /// <param name="value">Value assign to Credits</param>
    public void SetCredits(float value)
    {
        _Credits = value;
    }
    public float GetCredits()
    {
        return _Credits;
    }

    /// <summary>
    /// Get balance
    /// </summary>
    /// <returns>Balance</returns>
    public float GetBalance()
    {
        return _Charges - _Credits;
    }

    /// <summary>
    /// Set values into CreditLimit
    /// </summary>
    /// <param name="value">Value assign to CreditLimit</param>

    public void SetCreditLimit(float value)
    {
        _CreditLimit = value;
    }
    public float GetCreditLimit()
    {
        return _CreditLimit;
    }

    public void SetCreditScore(float value)
    {
        _creditScore = value;
    }
    public float GetCreditSCore()
    {
        return _creditScore;
    }
    public void SetCreditScore(string value)
    {
        if (value > 750)
        {
            _creditScore = value;
        }
        else
        {
            throw new Exception("You are not elligible to approve credit limit");

        }
    }
}
    }

 

}