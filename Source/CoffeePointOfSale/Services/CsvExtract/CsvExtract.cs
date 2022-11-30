using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.CsvExtract
{
    public class CsvExtract : ICsvExtract
    {
        public string Extract()
        {
            return "Hello from Extract Service!";
        }

        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? OrderId { get; set; }
        public string OrderDate { get; set; }
        public decimal OrderTotalPrice { get; set; }
        public string? OrderPaymentType { get; set; }
        public decimal? OrderSubTotal { get; set;}

        public decimal? OrderTax { get; set; }

    }
}
