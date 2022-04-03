using System.Text.Json;
using Lesson4.Models;

namespace Lesson4;

public class Jasongenerator
{
    public Jasongenerator()
    {
        List<Phone> phones = new();
        List<Auto> autos = new();
        List<Sticks> sticks = new();

        phones.Add(new Phone("iPhone", "13 Pro", 150000));
        phones.Add(new Phone("HONOR", "50 Lite", 100000));
        phones.Add(new Phone("OnePlus", "7 Pro", 100000));

        var file = new FileInfo("Phone.json");

        using (var json = file.Create())
        {
            JsonSerializer.Serialize(json, phones);
        }

        autos.Add(new Auto("AvtoVAZ ", "Vesta", 1000000));
        autos.Add(new Auto("Hyundai ", "Solaris", 1500000));
        autos.Add(new Auto("Mercedes", "EQE", 15000000));
        file = new FileInfo("Auto.json");

        using (var json = file.Create())
        {
            JsonSerializer.Serialize(json, autos);
        }

        sticks.Add(new Sticks("HEETS", "Purple", 160));
        sticks.Add(new Sticks("Fiit ", "Tropic", 1500000));
        file = new FileInfo("Sticks.json");

        using (var json = file.Create())
        {
            JsonSerializer.Serialize(json, sticks);
        }
    }
}