namespace Monitors;

internal class MemoryMonitorPipelineItem : MonitorPipelineItem
{
    protected override bool ReviewData(IMonitorData data)
    {
        if (data is null)
        {
            return false;
        }

        if (data.Memory < 2)
        {
            return false;
        }

        return true;
    }
}
