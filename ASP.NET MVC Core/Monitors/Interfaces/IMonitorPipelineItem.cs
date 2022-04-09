namespace Monitors;

internal interface IMonitorPipelineItem
{
    void SetNextItem(IMonitorPipelineItem pipelineItem);
    void ProcessData(IMonitorData data);

}
