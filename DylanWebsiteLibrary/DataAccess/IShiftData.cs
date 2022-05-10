
namespace DylanWebsiteLibrary.DataAccess;

public interface IShiftData
{
    Task<List<ShiftModel>> GetShiftsAsync();
    List<ShiftModel> GetShifts();
    Task InsertShift(ShiftModel shift);
    Task<List<ShiftModel>> GetShiftsForWorkerAsync(int id);
    List<ShiftModel> GetShiftsForWorker(int id);
    List<ShiftModel> GetShiftsBetweenDates(DateTime start, DateTime end);
    List<ShiftModel> GetShiftsBetweenDatesForWorker(int id, DateTime start, DateTime end);
}