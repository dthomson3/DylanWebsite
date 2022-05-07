namespace DylanWebsiteLibrary.Models;
public class ShiftModel
{
    public string Id { get; set; }
    public string ShiftType { get; set; }
    public string WorkerId { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }

}
