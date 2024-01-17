using System.Xml.Linq;
using _8xml.Strategy.Interfaces;

namespace _8xml.Strategy
{
    public class LINQReadXMLStrategy : IReadXMLStrategy
    {
        public IEnumerable<ScheduleItem> Read(string xmlFilePath)
        {
            var scheduleItems = XDocument.Load(xmlFilePath).Root!.Elements("ScheduleItem").Select(scientificFromXml => new ScheduleItem
                {
                    Id = int.Parse(scientificFromXml.Element("Id").Value),
                    ClassName = scientificFromXml.Element("ClassName").Value,
                    WorkingSpaceCapacity = scientificFromXml.Element("WorkingSpaceCapacity").Value,
                    User = scientificFromXml.Element("User").Value,
                    Teacher = scientificFromXml.Element("Teacher").Value,
                    FreeAccessTime = DateTime.Parse(scientificFromXml.Element("FreeAccessTime").Value),
                }).ToList();

            return scheduleItems;
        }
    }
}
