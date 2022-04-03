using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Models
{
    internal class Phone
    {
        internal string Name { get; set; }
        internal string Model { get; set; }
        internal float Price { get; set; }

        internal Phone(string name, string model, float price)
        {
            Name = name;
            Model = model;
            Price = price;
        }
    }
}
