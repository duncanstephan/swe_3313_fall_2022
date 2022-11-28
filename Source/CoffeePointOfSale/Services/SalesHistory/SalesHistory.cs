using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft;

namespace CoffeePointOfSale.Services.SalesHistory;

class SalesHistory
{
    private string DateTime = "";
    private Decimal Tax;
    private Decimal Subtotal;
    private Decimal Total;
    private int PointsEarned;
    private string Payment = "";
    private string PaymentDetails = "";

    //List<DrinkInOrder> drinksInOrder = new List<DrinkInOrder>();

}
