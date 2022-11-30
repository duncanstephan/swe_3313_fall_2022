using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeePointOfSale.Services.Customer;

namespace CoffeePointOfSale.Services.Customer;
public class DrinksInOrder
{
    public string Drink { get; set; }
    public decimal BasePrice { get; set; }    
    public string Description { get; set; }
    public decimal Price { get; set; }
}

