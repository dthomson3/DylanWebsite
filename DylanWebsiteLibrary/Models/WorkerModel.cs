namespace DylanWebsiteLibrary.Models;
public class WorkerModel
{
    public string Id { get; set; }
    public string ObjectIdentifier { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string EmploymentType { get; set; }

    public List<ShiftModel> RosteredShifts { get; set; }
}
