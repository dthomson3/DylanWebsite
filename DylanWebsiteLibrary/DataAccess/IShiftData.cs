
namespace DylanWebsiteLibrary.DataAccess;

public interface IShiftData
{
    Task<List<ShiftModel>> GetShifts();
    Task InsertShift(ShiftModel shift);
}