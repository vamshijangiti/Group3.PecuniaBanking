public class pecunia
{

    private string _customerName;
    private string _address;
    private string _occupation;
    private string _panCardNumber;
    private string _voterID;
    private string _passport;
    private string _drivingLicense;
    private int _aadhaarCardNumber;
    private string _utilityBillProof;
    private int _rationCardNumber;
    private int _employeeID;
    public void SavingsAccount(string customerName, string address, string occupation, string panCardNumber, string voterID, string passport, string drivingLicense, int aadhaarCardNumber)
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
    public void CurrentAccount(string utilityBillProof, int rationCardNumber, int employeeID)
    {
        UtilityBillProof = utilityBillProof;
        RationCardNumber = rationCardNumber;
        EmployeeID = employeeID;
    }
    /// <summary>
    /// set value into Customer Name
    /// </summary>
    /// <param name="customer Name"></param>
    public string CustomerName
    {
        set
        {
            //Name should be less than 20 characters
            if (value.Length <= 20)
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
            if (value.Length <= 95)
            {
                _address = value;
            }
            else
            {
                throw new System.Exception("you have entered Invalid Address");
            }
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
            if (value.Length == 10)
            {
                _panCardNumber = value;
            }
            else
            {
                throw new System.Exception("you have entered Invalid Pancard Number");
            }
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
            if (value.Length <= 10)
            {
                _voterID = value;
            }
            else
            {
                throw new System.Exception("VoterID should contain only 10 digits");
            }
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
            if (value.Length <= 8)
            {
                _passport = value;
            }
            else
            {
                throw new System.Exception("Passport number should contain only 8 digits");
            }
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
    public string UtilityBillProof
    {
        set
        {
            _utilityBillProof = value;
        }
        get
        {
            return _utilityBillProof;
        }
    }
    public int RationCardNumber
    {
        set
        {

            _rationCardNumber = value;
        }
        get
        {
            return _rationCardNumber;
        }
    }
    public int EmployeeID
    {
        set
        {
            _employeeID = value;
        }
        get
        {
            return _employeeID;
        }
    }
}

