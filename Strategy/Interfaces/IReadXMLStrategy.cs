namespace _8xml.Strategy.Interfaces
{
    public interface IReadXMLStrategy
    {
        IEnumerable<ScheduleItem> Read(string xmlFilePath);
    }
}
