using razor.Core.Repositories.Schedules;
using Microsoft.EntityFrameworkCore;
using razor.Core.Data.DataBase;

public class DbBuilder
{
    public IServiceCollection AddDatabase(WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
        
        builder.Services.AddScoped<DbInstance>();
        builder.Services.AddScoped<SchedulesRepository>();

        return builder.Services;
    }
}