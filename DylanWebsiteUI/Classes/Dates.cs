namespace DylanWebsiteUI.Classes;

public class Dates
{
    public DateTime weekStart = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
    public DateTime weekEnd = DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(7);

    public void MoveForwardWeek()
    {
        weekStart = weekStart.AddDays(7);
        weekEnd = weekEnd.AddDays(7);
    }

    public void MoveBackWeek()
    {
        weekStart = weekStart.AddDays(-7);
        weekEnd = weekEnd.AddDays(-7);
    }
}

public static class DateTimeExtensions
{
    public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
    {
        int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
        return dt.AddDays(-1 * diff).Date;
    }
}