using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Customer;

public class SalesHistory
{
    public string DateTime { get; set; }
    public decimal Tax { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Total { get; set; }
    public int PointsEarned { get; set; }
    public string Payment { get; set; }
    public string PaymentDetails { get; set; }
    public List<DrinksInOrder> DrinksInOrder { get; set; } = new();
}
