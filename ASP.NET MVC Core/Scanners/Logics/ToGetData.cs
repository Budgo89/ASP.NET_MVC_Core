using System.Text.Json;
using Monitors.Models;
using Scanners.Interfaces;

namespace Scanners.Logics;

public class ToGetData : IToGetData
{
    private const string filePath = "Metrics.json";

    public IMetrics metrics;

    private void DeserializeAuto(string filePath)
    {
        using (var json = File.OpenRead(filePath))
        {
            metrics.Metrics = JsonSerializer.Deserialize<List<IMetrics>>(json);
        }
    }

    public List<IMetrics> GetMetrics()
    {
        DeserializeAuto(filePath);
        return metrics.Metrics;
    }
}
