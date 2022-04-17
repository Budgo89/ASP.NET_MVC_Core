namespace Lesson4.Models;

public class Sticks : IModel
{
    public string Manufacturer { get; set; }
    public string Taste { get; set; }
    public float Price { get; set; }

    public Sticks(string manufacturer, string taste, float price)
    {
        Manufacturer = manufacturer;
        Taste = taste;
        Price = price;
    }
}
