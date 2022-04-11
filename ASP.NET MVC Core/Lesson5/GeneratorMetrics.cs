using System.Text.Json;

namespace Lesson5;

internal class GeneratorMetrics
{
    public GeneratorMetrics()
    {
        Random random = new Random();

        List<Metrics> metrics = new();

        for (int i = 0; i< 1000; i++)
        {
            metrics.Add( new Metrics()
            {
                Cpu = random.Next(1,100),
                Memory = random.Next(100, 6000)
            } );
        }

        var file = new FileInfo("Metrics.json");
        using (var json = file.Create())
        {
            JsonSerializer.Serialize(json, metrics);
        }
    }

}
