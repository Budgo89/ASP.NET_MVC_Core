namespace Monitors.Models;

public interface IMetrics
{
    int Cpu { get; set; }
    int Memory { get; set; }

    List<IMetrics> Metrics { get; set; }
}