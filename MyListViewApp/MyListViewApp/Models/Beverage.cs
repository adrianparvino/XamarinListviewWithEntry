using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListViewApp.Models
{
    public class Beverage
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public Store Store { get; set; }

        public Beverage(string name, double quantity, Store store)
        {
            Name = name;
            Quantity = quantity;
            Store = store;
        }
    }
}
