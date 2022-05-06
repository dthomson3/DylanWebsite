namespace DylanWebsiteLibrary.DataAccess;
public class PeopleData : IPeopleData
{
    private readonly ISqlDataAccess _db;

    public PeopleData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<List<PersonModel>> GetPeople()
    {
        string sql = "select * from dbo.TestData";

        return _db.LoadData<PersonModel, dynamic>(sql, new { });
    }

    public Task InsertPerson(PersonModel person)
    {
        string sql = @"insert int dbo.People (FirstName, LastName, EmailAddress)
                      values (@FirstName, @LastName, @EmailAddress);";

        return _db.SaveData(sql, person);
    }
}
