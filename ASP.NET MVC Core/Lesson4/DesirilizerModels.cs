using System.Text.Json;
using Lesson4.Models;

namespace Lesson4;
internal class DesirilizerModels
{
    private List<Phone>? _phones = new();
    private List<Auto>? _autos = new();
    private List<Sticks>? _sticks = new();

    public void StartDeserialize(EnumModel enumModel, string filePath)
    {
        switch (enumModel)
        {
            case EnumModel.Phone:
                if(DeserializePhone(filePath))
                    PrintPhones();
                else PrintError();
                break;
            case EnumModel.Auto:
                if(DeserializeAuto(filePath))
                    PrintAuto();
                else PrintError();
                break;
            case EnumModel.Sticks:
                if (DeserializeSticks(filePath))
                    PrintSticks();
                else PrintError(); 
                break;
            default:
                PrintError();
                break;
        }
    }

    private void PrintError()
    {
        Console.WriteLine("неверная модель или имя файла");
        Console.WriteLine();
    }

    private void PrintSticks()
    {
        if (_sticks!.Count == 0)
            return;
        foreach (var stick in _sticks)
        {
            Console.WriteLine(stick.Manufacturer);
            Console.WriteLine(stick.Taste);
            Console.WriteLine(stick.Price);
            Console.WriteLine();
        }
    }
    private void PrintAuto()
    {
        if(_autos!.Count == 0)
            return;
        foreach (var auto in _autos)
        {
            Console.WriteLine(auto.Model);
            Console.WriteLine(auto.Marka);
            Console.WriteLine(auto.Price);
            Console.WriteLine();
        }
    }
    private void PrintPhones()
    {
        if (_phones!.Count == 0)
            return;
        foreach (var phone in _phones)
        {
            Console.WriteLine(phone.Name);
            Console.WriteLine(phone.Model);
            Console.WriteLine(phone.Price);
            Console.WriteLine();
        }
    }

    private bool DeserializePhone(string filePath)
    {
        using (var json = File.OpenRead(filePath))
        {
            _phones = JsonSerializer.Deserialize<List<Phone>>(json);
        }
        return _phones == null || _phones.Count != 0;
    }
    private bool DeserializeAuto(string filePath)
    {
        using (var json = File.OpenRead(filePath))
        {
            _autos = JsonSerializer.Deserialize<List<Auto>>(json);
        }
        return _autos == null || _autos.Count != 0;
    }
    private bool DeserializeSticks(string filePath)
    {
        using (var json = File.OpenRead(filePath))
        {
            _sticks = JsonSerializer.Deserialize<List<Sticks>>(json);
        }
        return _sticks == null || _sticks.Count != 0;
    }
}
