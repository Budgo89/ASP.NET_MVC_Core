namespace Monitors
{
    internal class MonitorDeviceContext
    {
        private readonly IMonitoringSystemDevice _monitoringSystemDevice;
        public MonitorDeviceContext(IMonitoringSystemDevice
            monitoringSystemDevice)
        {
            _monitoringSystemDevice = monitoringSystemDevice;
        }
        public void RunMonitorProcess()
        {
            IMonitorPipelineItem pipelineItem = CreatePipeline();
            foreach (IMonitorData data in _monitoringSystemDevice)
            {
                pipelineItem.ProcessData(data);
            }
        }
        private IMonitorPipelineItem CreatePipeline()
        {
            IMonitorPipelineItem cpuMonitorPipelineItem = new CpuMonitorPipelineItem();
            IMonitorPipelineItem memoryMonitorPipelineItem = new MemoryMonitorPipelineItem();
            cpuMonitorPipelineItem.SetNextItem(memoryMonitorPipelineItem);
            return cpuMonitorPipelineItem;
        }
    }

}
}
