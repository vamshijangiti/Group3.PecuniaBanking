public class pecunia
{

    private protected string _customerName;
    private string _address;
    private string _occupation;
    private protected string _panCardNumber;
    private protected string _voterID;
    private protected string _passport;
    private protected string _drivingLicense;
    private protected int _aadhaarCardNumber;
    public pecunia(string customerName, string address, string occupation, string panCardNumber, string voterID, string passport, string drivingLicense, int aadhaarCardNumber)
    {


        CustomerName = customerName;
        Address = address;
        Occupation = occupation;
        PanCardNumber = panCardNumber;
        VoterID = voterID;
        Passport = passport;
        DrivingLicense = drivingLicense;
        AadhaarCardNumber = aadhaarCardNumber;

    }

    public string CustomerName
    {
        set
        {
            //Name should be less than 30 characters
            if (value.Length <= 30)
            {
                _customerName = value;
            }
        }

        get
        {
            return _customerName;
        }
    }
    public string Address
    {
        set
        {
            _address = value;
        }

        get
        {
            return _address;
        }
    }
    public string Occupation
    {
        set
        {
            _occupation = value;
        }

        get
        {
            return _occupation;
        }
    }

    public string PanCardNumber
    {
        set
        {
            _panCardNumber = value;
        }

        get
        {
            return _panCardNumber;
        }
    }
    public string VoterID
    {
        set
        {
            _voterID = value;
        }

        get
        {
            return _voterID;
        }
    }
    public string Passport
    {
        set
        {
            _passport = value;
        }

        get
        {
            return _passport;
        }
    }

    public string DrivingLicense
    {
        set
        {
            _drivingLicense = value;
        }

        get
        {
            return _drivingLicense;
        }
    }
    public int AadhaarCardNumber
    {
        set
        {
            _aadhaarCardNumber = value;
        }

        get
        {
            return _aadhaarCardNumber;
        }
    }

}




public class CurrentAccount
{
    private bool _utilityBill;
    private int _rationCardNumber;
    private int _employID;
    public void SetutilityBill(bool value)
    {
        _utilityBill = value;
    }
    public bool GetutilityBill()
    {
        return _utilityBill;
    }
    public void SetrationCardNumber(int value)
    {
        _rationCardNumber = value;
    }
    public int GetrationCardNumber()
    {
        return _rationCardNumber;
    }
    public void SetemployID(int value)
    {
        _employID = value;
    }
    public int GetemployID()
    {
        return _employID;
    }

}


