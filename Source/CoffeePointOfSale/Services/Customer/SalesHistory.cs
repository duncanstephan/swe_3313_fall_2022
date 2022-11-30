using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Customer;

public class SalesHistory
{
    public string DateTime { get; set; }
    public Decimal Tax { get; set; }    
    public Decimal Subtotal { get; set; }
    public Decimal Total { get; set; }
    public int PointsEarned { get; set; }
    public string Payment { get; set; }
    public string PaymentDetails { get; set; }

    List<DrinksInOrder> drinksInOrder { get; set; } = new();

    //Needs to send info to CSV Formatter
}