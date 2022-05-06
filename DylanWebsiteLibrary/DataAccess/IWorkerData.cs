
namespace DylanWebsiteLibrary.DataAccess;

public interface IWorkerData
{
    Task<List<WorkerModel>> GetWorkers();
    Task InsertWorker(WorkerModel worker);
}