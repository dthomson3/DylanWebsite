namespace DylanWebsiteLibrary.Models;
public class ShiftModel
{
    public string Id { get; set; }
    public string ShiftType { get; set; }
    public string WorkerId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

}
