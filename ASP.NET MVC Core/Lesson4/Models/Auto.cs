namespace Lesson4.Models;

public class Auto : IModel
{
    public string Model { get; set; }
    public string Marka { get; set; }
    public float Price { get; set; }

    public Auto(string model, string marka, float price)
    {
        Model = model;
        Marka = marka;
        Price = price;
    }
}
