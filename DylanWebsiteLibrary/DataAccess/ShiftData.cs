using System.Linq;

namespace DylanWebsiteLibrary.DataAccess;
public class ShiftData : IShiftData
{
    private readonly ISqlDataAccess _db;

    public ShiftData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<List<ShiftModel>> GetShiftsAsync()
    {
        string sql = "select * from dbo.Shifts";

        return _db.LoadDataAsync<ShiftModel, dynamic>(sql, new { });
    }

    public List<ShiftModel> GetShifts()
    {
        string sql = "select * from dbo.Shifts";

        return _db.LoadData<ShiftModel, dynamic>(sql, new { });
    }

    public async Task<List<ShiftModel>> GetShiftsForWorkerAsync(int id)
    {
        List<ShiftModel> shifts = await GetShiftsAsync();
        List<ShiftModel> workedShifts = shifts.Where(s => s.WorkerId == id.ToString()).ToList();
        return workedShifts;
    }

    public List<ShiftModel> GetShiftsForWorker(int id)
    {
        List<ShiftModel> workedShifts = GetShifts().Where(s => s.WorkerId == id.ToString()).ToList();
        SortListByDate(workedShifts);
        return workedShifts;
    }

    public List<ShiftModel> GetShiftsBetweenDates(DateTime start, DateTime end)
    {
        List<ShiftModel> shifts = GetShifts().Where(s => DateTime.Compare(s.Date, start) >= 0 && DateTime.Compare(s.Date, end) <= 0).ToList();
        SortListByDate(shifts);
        return shifts;
    }

    public List<ShiftModel> GetShiftsBetweenDatesForWorker(int id, DateTime start, DateTime end)
    {
        List<ShiftModel> shifts = GetShiftsBetweenDates(start, end).Where(s => s.WorkerId == id.ToString()).ToList();
        return shifts;
    }

    public Task InsertShift(ShiftModel shift)
    {
        string sql = @"insert into dbo.Shifts (ShiftType, WorkerId, Date, StartTime, EndTime)
                      values (@ShiftType, @WorkerId, @Date, @StartTime, @EndTime);";

        return _db.SaveDataAsync(sql, shift);
    }

    public List<ShiftModel> SortListByDate(List<ShiftModel> shifts)
    {
        shifts.Sort((i1, i2) => DateTime.Compare(i1.Date, i2.Date));
        return shifts;
    }
}
