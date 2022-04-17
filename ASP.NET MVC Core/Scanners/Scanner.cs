using Monitors.Models;
using Scanners.Logics;

namespace Scanners;

public class Scanner
{
    private List<IMetrics> _metrics;
    private ToGetData _toGetData;
    private Monitors.Monitors _monitors;

    public Scanner(Monitors.Monitors monitors)
    {
        _toGetData = new ToGetData();
        _metrics = new List<IMetrics>();
        _monitors = monitors;
    }

    public void GeMetric()
    {
        _metrics = _toGetData.GetMetrics();
    }

    public void SetMetric()
    {
        _monitors.Save();
    }
}
