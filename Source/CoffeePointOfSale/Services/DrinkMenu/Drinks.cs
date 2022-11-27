using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkMenu
{
    internal class Drinks
    {
        List<Drink> arlist = new List<Drink>();



        public void Add(Drink drink)
        {
            arlist.Add(drink);
        }
    }
}
