using Newtonsoft.Json;
using CoffeePointOfSale.Services.DrinkInOrder;
using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Customer;

public partial class Customer
{
    public const string AnonymousCustomerId = "anonymous";

    private readonly ICustomerService _customerService; //using this to grab current number of customers in customerList.

    [JsonPropertyName("CID")]
    private int _id = 0;    //Needs to increment by one every time a new customer is added. Initializes at 0, on id getter call checks list count and increments.
    [JsonPropertyName("FirstName")]
    private string firstName = "f";
    [JsonPropertyName("LastName")]
    private string lastName = "l";
    [JsonPropertyName("Phone")]
    private string _phone = "3"; //backing field for Phone property. only needed because the setter has logic to handle nulls and trimming spaces.
    [JsonPropertyName("RewardPoints")]
    private int _rewardPoints;

    public virtual string Phone
    {
        get => _phone;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Phone cannot be empty or null");
            _phone = value.Trim(); //trim to remove leading or trailing spaces that might mess up the lookup function
        }
    }

    public virtual string FirstName
    {
        get => firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("First Name cannot be empty or null");
            firstName = value;
        }
    }

    public virtual string LastName
    {
        get => lastName;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("First Name cannot be empty or null");
            lastName = value;
        }
    }

    public virtual int RewardPoints

    {
        get => _rewardPoints;
        set
        {
            if (IsAnonymous) return; //you cannot set reward points for the anonymous customer record
            _rewardPoints = value;
        }
    }

    public int getRewardsPoints() { return _rewardPoints; }

    //Added by Ian - Method to increase _id by 1 every time a customer is added
    //Gets called in Customers.cs in the Add method
    public void setId()
    {
        _id = _customerService.Customers.List.Count;
        _id++;
    }

    [Newtonsoft.Json.JsonIgnore]
    public virtual bool IsAnonymous => Phone == AnonymousCustomerId;

    public List<SalesHistory> SalesHistory { get; set; } = new();

    public override string ToString()
    {
        return IsAnonymous
            ? "Anonymous Customer - No Reward Points"
            : $"{Phone}, Reward Points: {RewardPoints}";
    }
}