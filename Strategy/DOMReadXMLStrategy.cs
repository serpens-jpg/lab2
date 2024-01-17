using System.Xml;
using _8xml.Strategy.Interfaces;

namespace _8xml.Strategy
{
    public class DOMReadXMLStrategy : IReadXMLStrategy
    {
        public IEnumerable<ScheduleItem> Read(string xmlFilePath)
        {
            var scheduleItems = new List<ScheduleItem>();

            var xml = new XmlDocument();
            xml.Load(xmlFilePath);

            foreach (XmlNode node in xml.SelectNodes("//ScheduleItem"))
            {
                var scheduleItem = new ScheduleItem();

                foreach (XmlNode propertyNode in node.ChildNodes)
                {
                    switch (propertyNode.Name)
                    {
                        case "Id":
                            scheduleItem.Id = int.Parse(propertyNode.InnerText);
                            break;
                        case "ClassName":
                            scheduleItem.ClassName = propertyNode.InnerText;
                            break;
                        case "WorkingSpaceCapacity":
                            scheduleItem.WorkingSpaceCapacity = propertyNode.InnerText;
                            break;
                        case "User":
                            scheduleItem.User = propertyNode.InnerText;
                            break;
                        case "Teacher":
                            scheduleItem.Teacher = propertyNode.InnerText;
                            break;
                        case "FreeAccessTime":
                            scheduleItem.FreeAccessTime = DateTime.Parse(propertyNode.InnerText);
                            break;
                        default:
                            break;
                    }
                }

                scheduleItems.Add(scheduleItem);
            }

            return scheduleItems;
        }
    }
}
