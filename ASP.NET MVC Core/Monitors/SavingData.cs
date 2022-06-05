using System.Xml.Serialization;
using Monitors.Models;

namespace Monitors;

public class SavingData
{
    private const string PathXml = "Metrics.xml";
    
    public void XmlSer(List<IMetrics> metrics)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(IMetrics));

        using (FileStream fs = new FileStream(PathXml, FileMode.OpenOrCreate))
        {

            xmlSerializer.Serialize(fs, metrics);

            Console.WriteLine("Object has been serialized");
        }
    }
}
