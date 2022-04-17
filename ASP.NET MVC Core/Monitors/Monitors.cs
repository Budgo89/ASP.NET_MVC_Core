using Monitors.Models;

namespace Monitors;

public class Monitors
{
    private List<IMetrics> _metrics;

    public Monitors(List<IMetrics> metrics)
    {
        _metrics = metrics;
    }

    public void Save()
    {
        var save = new SavingData();
        save.XmlSer(_metrics);
    }
}
