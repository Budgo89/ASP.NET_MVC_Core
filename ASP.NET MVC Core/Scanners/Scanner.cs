using Monitors.Models;
using Scanners.Logics;

namespace Scanners;

public class Scanner
{
    private List<IMetrics> _metrics;
    private ToGetData _toGetData;

    public Scanner()
    {
        _toGetData = new ToGetData();
        _metrics = new List<IMetrics>();
    }

    public void GeMetric()
    {
        _metrics = _toGetData.GetMetrics();
    }

    public void SetMetric()
    {
        var monitor = new Monitors.Monitors(_metrics);
        monitor.Save();
    }
}
