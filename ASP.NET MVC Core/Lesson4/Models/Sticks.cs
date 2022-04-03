using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Models
{
    internal class Sticks
    {
        internal string Manufacturer { get; set; }
        internal string Taste { get; set; }
        internal float Price { get; set; }

        internal Sticks(string manufacturer, string taste, float price)
        {
            Manufacturer = manufacturer;
            Taste = taste;
            Price = price;
        }
    }
}
