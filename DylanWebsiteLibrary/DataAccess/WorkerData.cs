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

    public async Task<WorkerModel> GetWorkerFromId(int Id)
    {
        string sql = string.Format(@"select * from dbo.Workers 
                       where Id = {0}", Id);

        return await _db.LoadSingleData<WorkerModel>(sql);

    }

    public Task InsertWorker(WorkerModel worker)
    {
        string sql = @"insert into dbo.Workers (FirstName, LastName, EmailAddress, EmploymentType)
                      values (@FirstName, @LastName, @EmailAddress @EmploymentType);";

        return _db.SaveData(sql, worker);
    }
}
