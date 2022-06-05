namespace Lesson4.Models;

[Serializable]
public class Phone : IModel
{
    public string Name { get; set; }
    public string Model { get; set; }
    public float Price { get; set; }

    public Phone(string name, string model, float price)
    {
        Name = name;
        Model = model;
        Price = price;
    }
}

