namespace DylanWebsiteLibrary.DataAccess;
public class WorkerData : IWorkerData
{
    private readonly ISqlDataAccess _db;

    public WorkerData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<List<WorkerModel>> GetWorkers()
    {
        string sql = "select * from dbo.Workers";

        return _db.LoadData<WorkerModel, dynamic>(sql, new { });
    }

    public Task InsertWorker(WorkerModel worker)
    {
        string sql = @"insert into dbo.Workers (FirstName, LastName, EmailAddress, EmploymentType)
                      values (@FirstName, @LastName, @EmailAddress @EmploymentType);";

        return _db.SaveData(sql, worker);
    }
}
