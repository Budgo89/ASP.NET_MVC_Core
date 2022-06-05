using Monitors.Models;

namespace Scanners.Interfaces;

public interface IToGetData
{
    List<IMetrics> GetMetrics();
}