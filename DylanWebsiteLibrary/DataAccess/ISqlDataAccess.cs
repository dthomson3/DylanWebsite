namespace DylanWebsiteLibrary.DataAccess;

public interface ISqlDataAccess
{
    string ConnectionStringName { get; set; }

    Task<List<T>> LoadDataAsync<T, U>(string sql, U parameters);
    List<T> LoadData<T, U>(string sql, U parameters);
    Task SaveDataAsync<T>(string sql, T parameters);
    Task<T> LoadSingleDataAsync<T>(string sql);
    object LoadSingleData<T>(string sql);


}