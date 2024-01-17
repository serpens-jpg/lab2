using System.Xml;
using _8xml.Strategy.Interfaces;

namespace _8xml.Strategy
{
    public class SAXReadXMLStrategy : IReadXMLStrategy
    {
        public IEnumerable<ScheduleItem> Read(string xmlFilePath)
        {
            var scheduleItems = new List<ScheduleItem>();

            using (var reader = XmlReader.Create(xmlFilePath))
            {
                ScheduleItem scheduleItem = default!;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        switch (reader.Name)
                        {
                            case "ScheduleItem":
                                scheduleItem = new ScheduleItem();
                                break;
                            case "Id":
                                if (scheduleItem != null)
                                {
                                    scheduleItem.Id = int.Parse(reader.ReadElementContentAsString());
                                }
                                break;
                            case "ClassName":
                                if (scheduleItem != null)
                                {
                                    scheduleItem.ClassName = reader.ReadElementContentAsString();
                                }
                                break;
                            case "WorkingSpaceCapacity":
                                if (scheduleItem != null)
                                {
                                    scheduleItem.WorkingSpaceCapacity = reader.ReadElementContentAsString();
                                }
                                break;
                            case "User":
                                if (scheduleItem != null)
                                {
                                    scheduleItem.User = reader.ReadElementContentAsString();
                                }
                                break;
                            case "Teacher":
                                if (scheduleItem != null)
                                {
                                    scheduleItem.Teacher = reader.ReadElementContentAsString();
                                }
                                break;
                            case "FreeAccessTime":
                                if (scheduleItem != null)
                                {
                                    scheduleItem.FreeAccessTime = DateTime.Parse(reader.ReadElementContentAsString());
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    else 
                    if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "ScheduleItem")
                    {
                        scheduleItems.Add(scheduleItem);
                        scheduleItem = default!;
                    }
                }
            }

            return scheduleItems;
        }
    }
}
