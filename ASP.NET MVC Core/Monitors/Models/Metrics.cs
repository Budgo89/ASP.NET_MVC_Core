
namespace Monitors.Models
{
    internal class Metrics : IMetrics
    {
        public int Cpu { get; set; }
        public int Memory { get; set; }
        List<IMetrics>? IMetrics.Metrics { get ; set ; }
    }
}
