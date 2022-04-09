namespace Monitors;

internal interface IMonitoringSystemDevice
{
    IEnumerator<IMonitorData> GetEnumerator();
}
