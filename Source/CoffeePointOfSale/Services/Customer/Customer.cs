﻿using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Customer;

public class Customer
{
    public const string AnonymousCustomerId = "anonymous";

    private readonly ICustomerService _customerService; //using this to grab current number of customers in customerList.

    private int _id = 0;    //Needs to increment by one every time a new customer is added. Initializes at 0, on id getter call checks list count and increments.
    private string _firstName = "1";
    private string _lastName = "2";
    private string _phone = "3"; //backing field for Phone property. only needed because the setter has logic to handle nulls and trimming spaces.
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

    public virtual string First
    {
        get => _firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("First Name cannot be empty or null");
            _firstName = value.Trim(); //trim to remove leading or trailing spaces that might mess up the lookup function
        }
    }

    public virtual string Last
    {
        get => _lastName;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("First Name cannot be empty or null");
            _lastName = value.Trim(); //trim to remove leading or trailing spaces that might mess up the lookup function
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

    [JsonIgnore]
    public virtual bool IsAnonymous => Phone == AnonymousCustomerId;

    

    /*public override string ToString()
    {
        return IsAnonymous
            ? "Anonymous Customer - No Reward Points"
            : $"{Phone}, Reward Points: {RewardPoints}";
    }*/
}