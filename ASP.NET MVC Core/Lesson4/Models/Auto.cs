using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Models
{
    internal class Auto
    {
        internal string Model { get; set; }
        internal string Marka { get; set; }
        internal float Price { get; set; }

        internal Auto(string model, string marka, float price)
        {
            Model = model;
            Marka = marka;
            Price = price;
        }
    }
}
