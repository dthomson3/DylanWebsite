namespace DylanWebsiteUI;

public static class RegisterServices
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
        builder.Services.AddTransient<IPeopleData, PeopleData>();
        builder.Services.AddTransient<IShiftData, ShiftData>();
        builder.Services.AddTransient<IWorkerData, WorkerData>();


    }
}
