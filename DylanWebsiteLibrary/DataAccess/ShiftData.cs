namespace DylanWebsiteLibrary.DataAccess;
public class ShiftData : IShiftData
{
    private readonly ISqlDataAccess _db;

    public ShiftData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<List<ShiftModel>> GetShifts()
    {
        string sql = "select * from dbo.Shifts";

        return _db.LoadData<ShiftModel, dynamic>(sql, new { });
    }

    public Task InsertShift(ShiftModel shift)
    {
        string sql = @"insert into dbo.Shifts (ShiftType, WorkerId, Date, StartTime, EndTime)
                      values (@ShiftType, @WorkerId, @Date, @StartTime, @EndTime);";

        return _db.SaveData(sql, shift);
    }
}
