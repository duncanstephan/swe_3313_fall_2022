using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkMenu
{
    internal class Drink
    {
        public string Name { get; set; }
        public string BaseDescription { get; set; }
        public string Image { get; set; }
        public decimal BasePrice { get; set; }
        public List<Customization> Customizations { get; set; }
    }
    public class Customization
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
